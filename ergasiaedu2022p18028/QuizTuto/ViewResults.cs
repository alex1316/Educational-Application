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
    public partial class ViewResults : Form
    {
        public ViewResults()
        {
            InitializeComponent();
            GetSubjects1();
            DisplayResults();
            GetCandidate();
           
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexa\Documents\QuizDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void GetSubjects1()
        {
            Con.Open();
            SqlCommand cms = new SqlCommand("select SName from SubjectTbl", Con);
            SqlDataReader sdr;
            sdr = cms.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SName", typeof(string));
            dt.Load(sdr);
            SubjectCb1.ValueMember = "SName";
            SubjectCb1.DataSource = dt;
            Con.Close();
        }

        private void GetCandidate()
        {
            Con.Open();
            SqlCommand cms = new SqlCommand("select CName from CandidateTbl", Con);
            SqlDataReader sdr;
            sdr = cms.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CName", typeof(string));
            dt.Load(sdr);
            CandidateCb.ValueMember = "CName";
            CandidateCb.DataSource = dt;
            Con.Close();
        }

        private void DisplayResults()
        {
            Con.Open();
            string Query = "select * from ResultTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ResultsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void FilterBySub()
        {
            Con.Open();
            string Query = "select * from ResultTbl where RSubject = '"+ SubjectCb1.SelectedValue.ToString() +"'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ResultsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void FilterByCand()
        {
            Con.Open();
            string Query = "select * from ResultTbl where RCandidate = '" + CandidateCb.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ResultsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CandidateCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubjectCb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubjectCb1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterBySub();
        }

        private void CandidateCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCand();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Candidates cand5 = new Candidates();
            cand5.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Questions gue5 = new Questions();
            gue5.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Subjects subj5 = new Subjects();
            subj5.Show();
            this.Hide();
        }
    }
}
