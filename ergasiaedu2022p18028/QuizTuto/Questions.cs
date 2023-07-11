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

namespace QuizTuto
{
    public partial class Questions : Form
    {
        int questionsId;
        public Questions()
        {
            InitializeComponent();
            GetSubjects();
            DisplayQuestions();
        }
        private void Reset() {
            QuestTb.Text = "";
            Op1Tb.Text = "";
            Op2Tb.Text = "";
            Op3Tb.Text = "";
            Op4Tb.Text = "";
            AnswerTb.Text = "";
            SubjectCb.SelectedIndex = 0;

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexa\Documents\QuizDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void GetSubjects() {
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisplayQuestions()
        {
            Con.Open();
            string Query = "select * from QuestionTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            QuestionsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Subjects subj = new Subjects();
            subj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Candidates candi = new Candidates();
            candi.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (QuestTb.Text == "" || Op1Tb.Text == "" || Op2Tb.Text == "" || Op3Tb.Text == "" || Op4Tb.Text == "" || AnswerTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int score = 0;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into QuestionTbl (QDesc,QO1,QO2,QO3,QO4,QA,QS) values (@Qd,@Q1,@Q2,@Q3,@Q4,@Qan,@Qsu)", Con);
                    cmd.Parameters.AddWithValue("@Qd", QuestTb.Text);
                    cmd.Parameters.AddWithValue("@Q1", Op1Tb.Text);
                    cmd.Parameters.AddWithValue("@Q2", Op2Tb.Text);
                    cmd.Parameters.AddWithValue("@Q3", Op3Tb.Text);
                    cmd.Parameters.AddWithValue("@Q4", Op4Tb.Text);
                    cmd.Parameters.AddWithValue("@Qan", AnswerTb.Text);
                    cmd.Parameters.AddWithValue("@Qsu", SubjectCb.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question Added");
                    Con.Close();
                    Reset();
                    DisplayQuestions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int key = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (QuestTb.Text == "" || Op1Tb.Text == "" || Op2Tb.Text == "" || Op3Tb.Text == "" || Op4Tb.Text == "" || AnswerTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update QuestionTbl set QDesc='" + QuestTb.Text + "',QO1='" + Op1Tb.Text + "',QO2='" + Op2Tb.Text + "',QO3='" + Op3Tb.Text + "',QO4='" + Op4Tb.Text + "',QA='" + AnswerTb.Text + "',QS='" + SubjectCb.SelectedValue.ToString() + "' where QId='" + questionsId + "' ", Con);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question Update");
                    Con.Close();
                    Reset();
                    DisplayQuestions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void QuestionsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            questionsId = Convert.ToInt32(QuestionsDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            QuestTb.Text = QuestionsDGV.SelectedRows[key].Cells[1].Value.ToString();
            Op1Tb.Text =QuestionsDGV.SelectedRows[0].Cells[2].Value.ToString();
            Op2Tb.Text = QuestionsDGV.SelectedRows[0].Cells[3].Value.ToString();
            Op3Tb.Text = QuestionsDGV.SelectedRows[0].Cells[4].Value.ToString();
            Op4Tb.Text = QuestionsDGV.SelectedRows[0].Cells[5].Value.ToString();
            AnswerTb.Text = QuestionsDGV.SelectedRows[0].Cells[6].Value.ToString();
            SubjectCb.SelectedValue = QuestionsDGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Questions_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            ViewResults vr = new ViewResults   ();
            vr.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            QuestionHelp queh = new QuestionHelp ();
            queh.Show();
        }
    } 
}
