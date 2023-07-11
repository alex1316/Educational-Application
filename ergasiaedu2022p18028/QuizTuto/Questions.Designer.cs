namespace QuizTuto
{
    partial class Questions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.QuestionsDGV = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SubjectCb = new System.Windows.Forms.ComboBox();
            this.AnswerTb = new System.Windows.Forms.TextBox();
            this.Op4Tb = new System.Windows.Forms.TextBox();
            this.Op3Tb = new System.Windows.Forms.TextBox();
            this.Op2Tb = new System.Windows.Forms.TextBox();
            this.Op1Tb = new System.Windows.Forms.TextBox();
            this.QuestTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "IT CLASS QUIZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Questions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(905, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Candidates";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(647, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subjects";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(403, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 10);
            this.panel3.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.QuestionsDGV);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SubjectCb);
            this.panel1.Controls.Add(this.AnswerTb);
            this.panel1.Controls.Add(this.Op4Tb);
            this.panel1.Controls.Add(this.Op3Tb);
            this.panel1.Controls.Add(this.Op2Tb);
            this.panel1.Controls.Add(this.Op1Tb);
            this.panel1.Controls.Add(this.QuestTb);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1599, 991);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(627, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Question Bank";
            // 
            // QuestionsDGV
            // 
            this.QuestionsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuestionsDGV.Location = new System.Drawing.Point(0, 459);
            this.QuestionsDGV.Name = "QuestionsDGV";
            this.QuestionsDGV.RowHeadersWidth = 51;
            this.QuestionsDGV.RowTemplate.Height = 24;
            this.QuestionsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QuestionsDGV.Size = new System.Drawing.Size(1588, 521);
            this.QuestionsDGV.TabIndex = 16;
            this.QuestionsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.QuestionsDGV_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(825, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 95);
            this.button3.TabIndex = 15;
            this.button3.Text = "RESET";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(633, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 95);
            this.button2.TabIndex = 14;
            this.button2.Text = "EDIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 95);
            this.button1.TabIndex = 13;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SubjectCb
            // 
            this.SubjectCb.BackColor = System.Drawing.Color.FloralWhite;
            this.SubjectCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectCb.FormattingEnabled = true;
            this.SubjectCb.Location = new System.Drawing.Point(1046, 317);
            this.SubjectCb.Name = "SubjectCb";
            this.SubjectCb.Size = new System.Drawing.Size(171, 24);
            this.SubjectCb.TabIndex = 12;
            this.SubjectCb.Text = "Subject";
            // 
            // AnswerTb
            // 
            this.AnswerTb.BackColor = System.Drawing.Color.FloralWhite;
            this.AnswerTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerTb.Location = new System.Drawing.Point(825, 208);
            this.AnswerTb.Name = "AnswerTb";
            this.AnswerTb.Size = new System.Drawing.Size(190, 30);
            this.AnswerTb.TabIndex = 11;
            this.AnswerTb.Text = "Answer";
            // 
            // Op4Tb
            // 
            this.Op4Tb.BackColor = System.Drawing.Color.FloralWhite;
            this.Op4Tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Op4Tb.Location = new System.Drawing.Point(525, 208);
            this.Op4Tb.Name = "Op4Tb";
            this.Op4Tb.Size = new System.Drawing.Size(190, 30);
            this.Op4Tb.TabIndex = 10;
            this.Op4Tb.Text = "Option4";
            // 
            // Op3Tb
            // 
            this.Op3Tb.BackColor = System.Drawing.Color.FloralWhite;
            this.Op3Tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Op3Tb.Location = new System.Drawing.Point(231, 208);
            this.Op3Tb.Name = "Op3Tb";
            this.Op3Tb.Size = new System.Drawing.Size(190, 30);
            this.Op3Tb.TabIndex = 9;
            this.Op3Tb.Text = "Option3";
            // 
            // Op2Tb
            // 
            this.Op2Tb.BackColor = System.Drawing.Color.FloralWhite;
            this.Op2Tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Op2Tb.Location = new System.Drawing.Point(825, 145);
            this.Op2Tb.Name = "Op2Tb";
            this.Op2Tb.Size = new System.Drawing.Size(190, 30);
            this.Op2Tb.TabIndex = 8;
            this.Op2Tb.Text = "Option2";
            // 
            // Op1Tb
            // 
            this.Op1Tb.BackColor = System.Drawing.Color.FloralWhite;
            this.Op1Tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Op1Tb.Location = new System.Drawing.Point(525, 145);
            this.Op1Tb.Name = "Op1Tb";
            this.Op1Tb.Size = new System.Drawing.Size(190, 30);
            this.Op1Tb.TabIndex = 7;
            this.Op1Tb.Text = "Option1";
            // 
            // QuestTb
            // 
            this.QuestTb.BackColor = System.Drawing.Color.FloralWhite;
            this.QuestTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestTb.Location = new System.Drawing.Point(231, 145);
            this.QuestTb.Name = "QuestTb";
            this.QuestTb.Size = new System.Drawing.Size(190, 30);
            this.QuestTb.TabIndex = 6;
            this.QuestTb.Text = "Question";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1151, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "Results";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1361, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 59);
            this.button4.TabIndex = 20;
            this.button4.Text = "HELP";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1603, 993);
            this.Controls.Add(this.panel1);
            this.Name = "Questions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Questions_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox QuestTb;
        private System.Windows.Forms.TextBox AnswerTb;
        private System.Windows.Forms.TextBox Op4Tb;
        private System.Windows.Forms.TextBox Op3Tb;
        private System.Windows.Forms.TextBox Op2Tb;
        private System.Windows.Forms.TextBox Op1Tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox SubjectCb;
        private System.Windows.Forms.DataGridView QuestionsDGV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
    }
}

