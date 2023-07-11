using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Data.SqlClient;

namespace QuizTuto
{
    public partial class Subjects : Form
    {
        int SubjectsId;
        public Subjects()
        {
            InitializeComponent();
            DisplaySubjects();
        }
        int Key = 0;
        private void Reset()
        {
            SNameTb.Text = "";
            int Key = 0;

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexa\Documents\QuizDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplaySubjects()
        {
            Con.Open();
            string Query = "select * from SubjectTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SubjectsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into SubjectTbl (SName) values (@Sn)", Con);
                    cmd.Parameters.AddWithValue("@Sn", SNameTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject saved");
                    Con.Close();
                    Reset();
                    DisplaySubjects();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SubjectsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SubjectsId = Convert.ToInt32(SubjectsDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            SNameTb.Text = SubjectsDGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reset();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update SubjectTbl set SName='" + SNameTb.Text + "'  where SId='" + SubjectsId + "' ", Con);

                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject Update");
                    Con.Close();
                    Reset();
                    DisplaySubjects();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Candidates cand = new Candidates();
            cand.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Questions gue = new Questions();
            gue.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            ViewResults vr = new ViewResults();
            vr.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SubjectHelp subh = new SubjectHelp();
            subh.Show();
        }
    }
}
