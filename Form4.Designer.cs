namespace ExamManagement
{
    partial class Form4
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
            this.labelIDOQ = new System.Windows.Forms.Label();
            this.IDOQ = new System.Windows.Forms.TextBox();
            this.Answer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveOQ = new System.Windows.Forms.Button();
            this.Rating2 = new System.Windows.Forms.TextBox();
            this.labelRating1 = new System.Windows.Forms.Label();
            this.Statement2 = new System.Windows.Forms.TextBox();
            this.labelStatement2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIDOQ
            // 
            this.labelIDOQ.AutoSize = true;
            this.labelIDOQ.Location = new System.Drawing.Point(14, 29);
            this.labelIDOQ.Name = "labelIDOQ";
            this.labelIDOQ.Size = new System.Drawing.Size(18, 13);
            this.labelIDOQ.TabIndex = 0;
            this.labelIDOQ.Text = "ID";
            // 
            // IDOQ
            // 
            this.IDOQ.Location = new System.Drawing.Point(83, 26);
            this.IDOQ.Name = "IDOQ";
            this.IDOQ.Size = new System.Drawing.Size(162, 20);
            this.IDOQ.TabIndex = 0;
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(345, 69);
            this.Answer.Multiline = true;
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(162, 76);
            this.Answer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Answer";
            // 
            // SaveOQ
            // 
            this.SaveOQ.Location = new System.Drawing.Point(249, 164);
            this.SaveOQ.Name = "SaveOQ";
            this.SaveOQ.Size = new System.Drawing.Size(95, 41);
            this.SaveOQ.TabIndex = 4;
            this.SaveOQ.Text = "Save";
            this.SaveOQ.UseVisualStyleBackColor = true;
            this.SaveOQ.Click += new System.EventHandler(this.SaveOQ_Click);
            // 
            // Rating2
            // 
            this.Rating2.Location = new System.Drawing.Point(322, 23);
            this.Rating2.Name = "Rating2";
            this.Rating2.Size = new System.Drawing.Size(131, 20);
            this.Rating2.TabIndex = 2;
            // 
            // labelRating1
            // 
            this.labelRating1.AutoSize = true;
            this.labelRating1.Location = new System.Drawing.Point(269, 26);
            this.labelRating1.Name = "labelRating1";
            this.labelRating1.Size = new System.Drawing.Size(38, 13);
            this.labelRating1.TabIndex = 7;
            this.labelRating1.Text = "Rating";
            // 
            // Statement2
            // 
            this.Statement2.Location = new System.Drawing.Point(83, 63);
            this.Statement2.Multiline = true;
            this.Statement2.Name = "Statement2";
            this.Statement2.Size = new System.Drawing.Size(190, 82);
            this.Statement2.TabIndex = 1;
            // 
            // labelStatement2
            // 
            this.labelStatement2.AutoSize = true;
            this.labelStatement2.Location = new System.Drawing.Point(16, 63);
            this.labelStatement2.Name = "labelStatement2";
            this.labelStatement2.Size = new System.Drawing.Size(55, 13);
            this.labelStatement2.TabIndex = 5;
            this.labelStatement2.Text = "Statement";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 220);
            this.Controls.Add(this.Rating2);
            this.Controls.Add(this.labelRating1);
            this.Controls.Add(this.Statement2);
            this.Controls.Add(this.labelStatement2);
            this.Controls.Add(this.SaveOQ);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDOQ);
            this.Controls.Add(this.labelIDOQ);
            this.Name = "Form4";
            this.ShowIcon = false;
            this.Text = "Open Question";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIDOQ;
        private System.Windows.Forms.TextBox IDOQ;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveOQ;
        private System.Windows.Forms.TextBox Rating2;
        private System.Windows.Forms.Label labelRating1;
        private System.Windows.Forms.TextBox Statement2;
        private System.Windows.Forms.Label labelStatement2;
    }
}