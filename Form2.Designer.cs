namespace ExamManagement
{
    partial class Form2
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
            this.OpenQ = new System.Windows.Forms.Button();
            this.ChoiceQ = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenQ
            // 
            this.OpenQ.Location = new System.Drawing.Point(82, 53);
            this.OpenQ.Name = "OpenQ";
            this.OpenQ.Size = new System.Drawing.Size(120, 41);
            this.OpenQ.TabIndex = 0;
            this.OpenQ.Text = "Open Question";
            this.OpenQ.UseVisualStyleBackColor = true;
            this.OpenQ.Click += new System.EventHandler(this.OpenQ_Click);
            // 
            // ChoiceQ
            // 
            this.ChoiceQ.Location = new System.Drawing.Point(239, 53);
            this.ChoiceQ.Name = "ChoiceQ";
            this.ChoiceQ.Size = new System.Drawing.Size(120, 41);
            this.ChoiceQ.TabIndex = 1;
            this.ChoiceQ.Text = "Choice Question";
            this.ChoiceQ.UseVisualStyleBackColor = true;
            this.ChoiceQ.Click += new System.EventHandler(this.ChoiceQ_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 254);
            this.dataGridView1.TabIndex = 9;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(7, 67);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 10;
            this.labelType.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Question List";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(7, 22);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 15;
            this.labelID.Text = "ID";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(59, 19);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(300, 20);
            this.ID.TabIndex = 16;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(276, 100);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(83, 38);
            this.Delete.TabIndex = 17;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 404);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ChoiceQ);
            this.Controls.Add(this.OpenQ);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Quetion List";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OpenQ;
        private System.Windows.Forms.Button ChoiceQ;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button Delete;
    }
}