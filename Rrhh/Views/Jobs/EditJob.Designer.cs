namespace Rrhh.Views.Jobs
{
    partial class EditJob
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
            this.UpdateJobBtn = new System.Windows.Forms.Button();
            this.descriptionTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DepartmentNameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectDepartmentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdateJobBtn
            // 
            this.UpdateJobBtn.Location = new System.Drawing.Point(127, 222);
            this.UpdateJobBtn.Name = "UpdateJobBtn";
            this.UpdateJobBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateJobBtn.TabIndex = 15;
            this.UpdateJobBtn.Text = "Update job";
            this.UpdateJobBtn.UseVisualStyleBackColor = true;
            this.UpdateJobBtn.Click += new System.EventHandler(this.UpdateJobBtn_Click);
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.Location = new System.Drawing.Point(98, 70);
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTxtBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Description";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(98, 35);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.NameTxtBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // DepartmentNameTxtBox
            // 
            this.DepartmentNameTxtBox.Enabled = false;
            this.DepartmentNameTxtBox.Location = new System.Drawing.Point(98, 106);
            this.DepartmentNameTxtBox.Name = "DepartmentNameTxtBox";
            this.DepartmentNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.DepartmentNameTxtBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Department";
            // 
            // selectDepartmentBtn
            // 
            this.selectDepartmentBtn.Location = new System.Drawing.Point(215, 100);
            this.selectDepartmentBtn.Name = "selectDepartmentBtn";
            this.selectDepartmentBtn.Size = new System.Drawing.Size(121, 31);
            this.selectDepartmentBtn.TabIndex = 8;
            this.selectDepartmentBtn.Text = "Select department";
            this.selectDepartmentBtn.UseVisualStyleBackColor = true;
            this.selectDepartmentBtn.Click += new System.EventHandler(this.selectDepartmentBtn_Click);
            // 
            // EditJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 350);
            this.Controls.Add(this.UpdateJobBtn);
            this.Controls.Add(this.descriptionTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DepartmentNameTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectDepartmentBtn);
            this.Name = "EditJob";
            this.Text = "EditJob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateJobBtn;
        private System.Windows.Forms.TextBox descriptionTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DepartmentNameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectDepartmentBtn;
    }
}