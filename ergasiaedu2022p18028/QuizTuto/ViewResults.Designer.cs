namespace QuizTuto
{
    partial class ViewResults
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ResultsDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SubjectCb1 = new System.Windows.Forms.ComboBox();
            this.CandidateCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Questions";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(918, 49);
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
            this.label4.Location = new System.Drawing.Point(711, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subjects";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(1178, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 10);
            this.panel3.TabIndex = 5;
            // 
            // ResultsDGV
            // 
            this.ResultsDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ResultsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsDGV.Location = new System.Drawing.Point(138, 287);
            this.ResultsDGV.Name = "ResultsDGV";
            this.ResultsDGV.RowHeadersWidth = 51;
            this.ResultsDGV.RowTemplate.Height = 24;
            this.ResultsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResultsDGV.Size = new System.Drawing.Size(1279, 558);
            this.ResultsDGV.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1172, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Results";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SubjectCb1
            // 
            this.SubjectCb1.BackColor = System.Drawing.Color.FloralWhite;
            this.SubjectCb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectCb1.FormattingEnabled = true;
            this.SubjectCb1.Location = new System.Drawing.Point(420, 235);
            this.SubjectCb1.Name = "SubjectCb1";
            this.SubjectCb1.Size = new System.Drawing.Size(281, 24);
            this.SubjectCb1.TabIndex = 20;
            this.SubjectCb1.Text = "Subject";
            this.SubjectCb1.SelectedIndexChanged += new System.EventHandler(this.SubjectCb1_SelectedIndexChanged);
            this.SubjectCb1.SelectionChangeCommitted += new System.EventHandler(this.SubjectCb1_SelectionChangeCommitted);
            // 
            // CandidateCb
            // 
            this.CandidateCb.BackColor = System.Drawing.Color.FloralWhite;
            this.CandidateCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CandidateCb.FormattingEnabled = true;
            this.CandidateCb.Location = new System.Drawing.Point(887, 235);
            this.CandidateCb.Name = "CandidateCb";
            this.CandidateCb.Size = new System.Drawing.Size(260, 24);
            this.CandidateCb.TabIndex = 21;
            this.CandidateCb.Text = "Candidate";
            this.CandidateCb.SelectedIndexChanged += new System.EventHandler(this.CandidateCb_SelectedIndexChanged);
            this.CandidateCb.SelectionChangeCommitted += new System.EventHandler(this.CandidateCb_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(736, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "Results";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(315, 46);
            this.label6.TabIndex = 24;
            this.label6.Text = "IT CLASS QUIZ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CandidateCb);
            this.panel1.Controls.Add(this.SubjectCb1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ResultsDGV);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-134, -26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1626, 874);
            this.panel1.TabIndex = 2;
            // 
            // ViewResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 822);
            this.Controls.Add(this.panel1);
            this.Name = "ViewResults";
            this.Text = "ViewResults";
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView ResultsDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SubjectCb1;
        private System.Windows.Forms.ComboBox CandidateCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}