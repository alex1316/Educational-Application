using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuizTuto
{
    public partial class Candidates : Form
    {
        int CandidatesId;
        public Candidates()
        {
            InitializeComponent();
            DisplayCandidates();
        }
        private void Reset() {
            CNameTb.Text = "";
            CAgeTb.Text = "";
            PhoneTb.Text = "";
            AddressTb.Text = "";
            PasswordTb.Text = "";
        
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexa\Documents\QuizDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayCandidates() {
            Con.Open();
            string Query = "select * from CandidateTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CandidatesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || CAgeTb.Text == "" || PasswordTb.Text == "" || PhoneTb.Text == "" || AddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int score = 0;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CandidateTbl (CName,CAge,CPass,CScore,CAdd,Cphone) values (@Cn,@Ca,@Cp,@Cs,@Cad,@Cph)", Con);
                    cmd.Parameters.AddWithValue("@Cn", CNameTb.Text);
                    cmd.Parameters.AddWithValue("@Ca", CAgeTb.Text);
                    cmd.Parameters.AddWithValue("@Cp", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@Cs", score);
                    cmd.Parameters.AddWithValue("@Cad", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@Cph", PhoneTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Candidate Saved");
                    Con.Close();
                    Reset();
                    DisplayCandidates();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || CAgeTb.Text == "" || PasswordTb.Text == "" || PhoneTb.Text == "" || AddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update CandidateTbl set CName='" + CNameTb.Text + "',CAge='" + CAgeTb.Text + "',CAdd='" + AddressTb.Text + "',CPass='" + PasswordTb.Text + "',Cphone='" + PhoneTb.Text + "' where CId='" + CandidatesId + "' ", Con);

                   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Candidate Updated");
                    Con.Close();
                    Reset();
                    DisplayCandidates();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int key = 0;
        private void CandidatesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CandidatesId = Convert.ToInt32(CandidatesDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            CNameTb.Text = CandidatesDGV.SelectedRows[0].Cells[1].Value.ToString();
            CAgeTb.Text = CandidatesDGV.SelectedRows[0].Cells[2].Value.ToString();
            PasswordTb.Text = CandidatesDGV.SelectedRows[0].Cells[3].Value.ToString();
            AddressTb.Text = CandidatesDGV.SelectedRows[0].Cells[5].Value.ToString();
            PhoneTb.Text = CandidatesDGV.SelectedRows[0].Cells[6].Value.ToString();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Subjects subj = new Subjects();
            subj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Questions que = new Questions();
            que.Show();
            this.Hide();
        }

        private void Candidates_Load(object sender, EventArgs e)
        {

        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            ViewResults vr = new ViewResults();
            vr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CandidateHelp cah = new CandidateHelp();
            cah.Show();
        }
    }
}
