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

namespace QuizTuto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            GetSubjects();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexa\Documents\QuizDB.mdf;Integrated Security=True;Connect Timeout=30");
        public static string CandName = "", SubName = "";
        private void GetSubjects()
        {
            Con.Open();
            SqlCommand cms = new SqlCommand("select SName from SubjectTbl", Con);
            SqlDataReader sdr;
            sdr = cms.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SName", typeof(string));
            dt.Load(sdr);
            SubjectCb.ValueMember = "SName";
            SubjectCb.DataSource = dt;
            Con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Missing Candidate's name and password");
            } else if (textBox1.Text == "admin" && textBox2.Text == "123456") { 
            
            Candidates can = new Candidates();
                can.Show();
                this.Hide();
            
            
            }
            else {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(" select count(*) from CandidateTbl where cpass='" + textBox2.Text + "' and CName='" + textBox1.Text + "' ", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    CandName = textBox1.Text;
                    SubName = SubjectCb.SelectedValue.ToString();
                    Exams obj = new Exams();
                    obj.Show();
                    this.Hide();
                    Con.Close();

                }
                else {
                    MessageBox.Show("wrong Candidate Name or Password");


                }
                Con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SubjectCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
