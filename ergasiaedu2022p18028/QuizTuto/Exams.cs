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
    public partial class Exams : Form
    {
        public Exams()
        {
            InitializeComponent();
            //multirandom();

            // timer1.Start();
            
            label5.Text = Login.CandName;
            label4.Text = Login.SubName;
            FetchQuestions();
            // qn=countQuestions();
           // HighScore();


        }
        int qn;

        private void Exams_Load(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexa\Documents\QuizDB.mdf;Integrated Security=True;Connect Timeout=30");
        String a1, a2, a3, a4, a5, a6, a7, a8, a9, a10;

        private int countQuestions() {
            int Qnum;
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from QuestionTbl where QS = '"+ label4.Text +"'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Qnum = Convert.ToInt32(dt.Rows[0][0]);
            Con.Close();
            //MessageBox.Show(""+Qnum);
            return Qnum;
        
        }

        private void HighScore() {
            Con.Open();
            SqlDataAdapter sda2 = new SqlDataAdapter("select Max(RScore) from ResultTbl where RCandidate = '" + label5.Text +"'",Con) ;
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            int bestscore = Convert.ToInt32(dt2.Rows[0][0].ToString());
            try
            {

                
                SqlCommand cmd = new SqlCommand("update CandidateTbl set CScore='" + bestscore + "' where CName='" + label5.Text + "' ", Con);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Candidate Updated");
                Con.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
        }

       /* private int GenerateRand() {
            Random rd = new Random();
            int x = rd.Next(6,9);
            int y = rd.Next(6, 9);
            int z = rd.Next(6, 9);
            MessageBox.Show(""+x+ "and"+y+"and"+z);
            return x;
        } */

        int[] Keys = new int[10];
        private void multirandom() {
            HashSet<int> numbers = new HashSet<int>();
            var rnd = new Random();
            while (numbers.Count < 10) {
                numbers.Add(rnd.Next(6, 19));
            }
            for (int i=0;i<10;i++) {
                Keys[i] = numbers.ElementAt(i);
            }
            
        }
      

        private void FetchQuestions()
        {
            try
            {
                //int Qnum = GenerateRand();
                multirandom();
                Con.Open();
                string Query = "select * from QuestionTbl where QId=" + Keys[0]  +"";
                SqlCommand cmd = new SqlCommand(Query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
               
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q1.Text = dr["QDesc"].ToString();
                        Q101.Text = dr["QO1"].ToString();
                        Q102.Text = dr["QO2"].ToString();
                        Q103.Text = dr["QO3"].ToString();
                        Q104.Text = dr["QO4"].ToString();
                        a1 = dr["QA"].ToString();
                  
                }

                string Query1 = "select * from QuestionTbl where QId=" + Keys[1] + "";
                cmd = new SqlCommand(Query1, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q2.Text = dr["QDesc"].ToString();
                    Q201.Text = dr["QO1"].ToString();
                    Q202.Text = dr["QO2"].ToString();
                    Q203.Text = dr["QO3"].ToString();
                    Q204.Text = dr["QO4"].ToString();
                    a2 = dr["QA"].ToString();

                }

                string Query2 = "select * from QuestionTbl where QId=" + Keys[2] + "";
                cmd = new SqlCommand(Query2, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q3.Text = dr["QDesc"].ToString();
                    Q301.Text = dr["QO1"].ToString();
                    Q302.Text = dr["QO2"].ToString();
                    Q303.Text = dr["QO3"].ToString();
                    Q304.Text = dr["QO4"].ToString();
                    a3 = dr["QA"].ToString();
                }

                string Query3 = "select * from QuestionTbl where QId=" + Keys[3] + "";
                cmd = new SqlCommand(Query3, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q4.Text = dr["QDesc"].ToString();
                    Q401.Text = dr["QO1"].ToString();
                    Q402.Text = dr["QO2"].ToString();
                    Q403.Text = dr["QO3"].ToString();
                    Q404.Text = dr["QO4"].ToString();
                    a4 = dr["QA"].ToString();
                }

                string Query4 = "select * from QuestionTbl where QId=" + Keys[4] + "";
                cmd = new SqlCommand(Query4, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q5.Text = dr["QDesc"].ToString();
                    Q501.Text = dr["QO1"].ToString();
                    Q502.Text = dr["QO2"].ToString();
                    Q503.Text = dr["QO3"].ToString();
                    Q504.Text = dr["QO4"].ToString();
                    a5 = dr["QA"].ToString();
                }

                string Query5 = "select * from QuestionTbl where QId=" + Keys[5] + "";
                cmd = new SqlCommand(Query5, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q6.Text = dr["QDesc"].ToString();
                    Q601.Text = dr["QO1"].ToString();
                    Q602.Text = dr["QO2"].ToString();
                    Q603.Text = dr["QO3"].ToString();
                    Q604.Text = dr["QO4"].ToString();
                    a6 = dr["QA"].ToString();
                }

                string Query6 = "select * from QuestionTbl where QId=" + Keys[6] + "";
                cmd = new SqlCommand(Query6, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q7.Text = dr["QDesc"].ToString();
                    Q701.Text = dr["QO1"].ToString();
                    Q702.Text = dr["QO2"].ToString();
                    Q703.Text = dr["QO3"].ToString();
                    Q704.Text = dr["QO4"].ToString();
                    a7 = dr["QA"].ToString();
                }

                string Query7 = "select * from QuestionTbl where QId=" + Keys[7] + "";
                cmd = new SqlCommand(Query7, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q8.Text = dr["QDesc"].ToString();
                    Q801.Text = dr["QO1"].ToString();
                    Q802.Text = dr["QO2"].ToString();
                    Q803.Text = dr["QO3"].ToString();
                    Q804.Text = dr["QO4"].ToString();
                    a8 = dr["QA"].ToString();
                }

                string Query8 = "select * from QuestionTbl where QId=" + Keys[8] + "";
                cmd = new SqlCommand(Query8, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q9.Text = dr["QDesc"].ToString();
                    Q901.Text = dr["QO1"].ToString();
                    Q902.Text = dr["QO2"].ToString();
                    Q903.Text = dr["QO3"].ToString();
                    Q904.Text = dr["QO4"].ToString();
                    a9 = dr["QA"].ToString();
                }

                string Query9 = "select * from QuestionTbl where QId=" + Keys[9] + "";
                cmd = new SqlCommand(Query9, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q10.Text = dr["QDesc"].ToString();
                    Q1001.Text = dr["QO1"].ToString();
                    Q1002.Text = dr["QO2"].ToString();
                    Q1003.Text = dr["QO3"].ToString();
                    Q1004.Text = dr["QO4"].ToString();
                    a10 = dr["QA"].ToString();
                }

                Con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        
        }

        private void Q102_CheckedChanged(object sender, EventArgs e)
        {
            //Ua[1] = Q102.Text;
            //MessageBox.Show("Saved answer is " + Ua[1]);
        }

        private void Q103_CheckedChanged(object sender, EventArgs e)
        {

        }
        String[] Ua = new string[10];
        private void Q101_CheckedChanged(object sender, EventArgs e)
        {
           // Ua[0] = Q101.Text;
            //MessageBox.Show("Saved answer is " + Ua[0]);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

       // private void radioButton4_CheckedChanged(object sender, EventArgs e)
        //{
          //  MessageBox.Show("Saved");
        //}

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {

        }


        int score = 0;

        private void checkQ1() {

            if (Q101.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q101.Text;
            }
            else if (Q102.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q102.Text;
            }
            else if (Q103.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q103.Text;
            }
            else if (Q104.Checked) 
            {
                Ua[0] = "";
                Ua[0] = Q104.Text;

            }
            if (Ua[0] == a1)
            {
                score = score + 1;

            }
            else {
                score = score;
            
            }
        }

        private void checkQ2()
        {

            if (Q201.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q201.Text;
            }
            else if (Q202.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q202.Text;
            }
            else if (Q203.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q203.Text;
            }
            else if (Q204.Checked) 
            {
                Ua[1] = "";
                Ua[1] = Q204.Text;

            }
            if (Ua[1] == a2)
            {
                score = score + 1;

            }
            else
            {
                score = score;

            }
        }

        private void checkQ3()
        {

            if (Q301.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q301.Text;
            }
            else if (Q302.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q302.Text;
            }
            else if (Q303.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q303.Text;
            }
            else if (Q304.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q304.Text;

            }
            if (Ua[2] == a3)
            {
                score = score + 1;

            }
            else
            {
                score = score;

            }
        }

        private void checkQ4()
        {

            if (Q401.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q401.Text;
            }
            else if (Q402.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q402.Text;
            }
            else if (Q403.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q403.Text;
            }
            else if (Q404.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q404.Text;

            }
            if (Ua[3] == a4)
            {
                score = score + 1;

            }
            else
            {
                score = score;

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ExamHelp exh = new ExamHelp();
            exh.Show();
        }

        private void checkQ5()
        {

            if (Q501.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q501.Text;
            }
            else if (Q502.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q502.Text;
            }
            else if (Q503.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q503.Text;
            }
            else if (Q504.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q504.Text;

            }
            if (Ua[4] == a5)
            {
                score = score + 1;

            }
            else
            {
                score = score;

            }
        }

        private void checkQ6()
        {

            if (Q601.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q601.Text;
            }
            else if (Q602.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q602.Text;
            }
            else if (Q603.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q603.Text;
            }
            else if (Q604.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q604.Text;

            }
            if (Ua[5] == a6)
            {
                score = score + 1;

            }
            else
            {
                score = score;

            }
        }

        private void checkQ7()
        {

            if (Q701.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q701.Text;
            }
            else if (Q702.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q702.Text;
            }
            else if (Q703.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q703.Text;
            }
            else if (Q704.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q704.Text;

            }
            if (Ua[6] == a7)
            {
                score = score + 1;

            }
            else
            {
                score = score;

            }
        }

        private void checkQ8()
        {

            if (Q801.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q801.Text;
            }
            else if (Q802.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q802.Text;
            }
            else if (Q803.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q803.Text;
            }
            else if (Q804.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q804.Text;

            }
            if (Ua[7] == a8)
            {
                score = score + 1;

            }
            else
            {
                score = score;

            }
        }

        private void checkQ9()
        {

            if (Q901.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q901.Text;
            }
            else if (Q902.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q902.Text;
            }
            else if (Q903.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q903.Text;
            }
            else if (Q904.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q904.Text;

            }
            if (Ua[8] == a9)
            {
                score = score + 1;

            }
            else
            {
                score = score;

            }
        }

        private void checkQ10()
        {

            if (Q1001.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q1001.Text;
            }
            else if (Q1002.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q1002.Text;
            }
            else if (Q1003.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q1003.Text;
            }
            else if (Q1004.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q1004.Text;

            }
            if (Ua[9] == a10)
            {
                score = score + 1;

            }
            else
            {
                score = score;

            }
        }

        private void insertResult() {

            try
            {
                
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ResultTbl (RSubject,RCandidate,RDate,RTime,RScore) values (@RS,@RC,@RD,@RT,@RSc)", Con);
                cmd.Parameters.AddWithValue("@RS", label4.Text);
                cmd.Parameters.AddWithValue("@RC", label5.Text);
                cmd.Parameters.AddWithValue("@RD", QDateP.Value.Date);
                cmd.Parameters.AddWithValue("@RT", QTimeP.Text);
                cmd.Parameters.AddWithValue("@RSc", score);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Result saved");
                Con.Close();
                // Reset();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void Reset() { 
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = 0;
            checkQ1();
            checkQ2();
            checkQ3();
            checkQ4();
            checkQ5();
            checkQ6();
            checkQ7();
            checkQ8();
            checkQ9();
            checkQ10();
           
            MessageBox.Show("" + score);
            insertResult();
            HighScore();
            if (score < 5)
            {
                Login log = new Login();
                log.Show();
                this.Hide();


                
                
            }
            else if (score >= 5 && score < 8)
            {
                Login log = new Login();
                log.Show();
                this.Hide();

               
                
               
            }
            else if (score >= 9) {
                Login log = new Login();
                log.Show();
                this.Hide();

                
                
               

            }
           
           
        }
       
    }
}
