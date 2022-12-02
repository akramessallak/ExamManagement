namespace ExamManagement
{
    partial class Form1
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
            this.ID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.TextBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.TextBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelExam = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(81, 22);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(178, 20);
            this.ID.TabIndex = 0;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(27, 25);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID";
            // 
            // Duration
            // 
            this.Duration.Location = new System.Drawing.Point(337, 22);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(178, 20);
            this.Duration.TabIndex = 1;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(283, 25);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(47, 13);
            this.labelDuration.TabIndex = 4;
            this.labelDuration.Text = "Duration";
            // 
            // From
            // 
            this.From.Location = new System.Drawing.Point(81, 62);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(178, 20);
            this.From.TabIndex = 2;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(27, 65);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(30, 13);
            this.labelFrom.TabIndex = 6;
            this.labelFrom.Text = "From";
            // 
            // To
            // 
            this.To.Location = new System.Drawing.Point(337, 65);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(178, 20);
            this.To.TabIndex = 3;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(283, 68);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(20, 13);
            this.labelTo.TabIndex = 8;
            this.labelTo.Text = "To";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(485, 194);
            this.dataGridView1.TabIndex = 10;
            // 
            // labelExam
            // 
            this.labelExam.AutoSize = true;
            this.labelExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExam.Location = new System.Drawing.Point(232, 100);
            this.labelExam.Name = "labelExam";
            this.labelExam.Size = new System.Drawing.Size(82, 31);
            this.labelExam.TabIndex = 11;
            this.labelExam.Text = "Exam";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(30, 334);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 43);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(137, 334);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 43);
            this.Update.TabIndex = 5;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(239, 334);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 43);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(440, 334);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 43);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(337, 334);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 43);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 390);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.labelExam);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.To);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.From);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.labelID);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Create Exam";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox Duration;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.TextBox From;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelExam;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
    }
}

