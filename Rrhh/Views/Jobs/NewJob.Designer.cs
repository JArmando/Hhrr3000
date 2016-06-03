namespace Rrhh.Views.Jobs
{
    partial class NewJob
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
            this.selectDepartmentBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateJobBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectDepartmentBtn
            // 
            this.selectDepartmentBtn.Location = new System.Drawing.Point(272, 154);
            this.selectDepartmentBtn.Name = "selectDepartmentBtn";
            this.selectDepartmentBtn.Size = new System.Drawing.Size(121, 31);
            this.selectDepartmentBtn.TabIndex = 0;
            this.selectDepartmentBtn.Text = "Select department";
            this.selectDepartmentBtn.UseVisualStyleBackColor = true;
            this.selectDepartmentBtn.Click += new System.EventHandler(this.selectDepartmentBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(155, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(155, 89);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.NameTxtBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.Location = new System.Drawing.Point(155, 124);
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTxtBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // CreateJobBtn
            // 
            this.CreateJobBtn.Location = new System.Drawing.Point(184, 276);
            this.CreateJobBtn.Name = "CreateJobBtn";
            this.CreateJobBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateJobBtn.TabIndex = 7;
            this.CreateJobBtn.Text = "Create job";
            this.CreateJobBtn.UseVisualStyleBackColor = true;
            this.CreateJobBtn.Click += new System.EventHandler(this.CreateJobBtn_Click);
            // 
            // NewJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 420);
            this.Controls.Add(this.CreateJobBtn);
            this.Controls.Add(this.descriptionTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectDepartmentBtn);
            this.Name = "NewJob";
            this.Text = "NewJob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectDepartmentBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateJobBtn;
    }
}