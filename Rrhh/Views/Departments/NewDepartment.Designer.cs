namespace Rrhh.Views.Departments
{
    partial class NewDepartment
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
            this.CreateDepartmentBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.DescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateDepartmentBtn
            // 
            this.CreateDepartmentBtn.Location = new System.Drawing.Point(99, 58);
            this.CreateDepartmentBtn.Name = "CreateDepartmentBtn";
            this.CreateDepartmentBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateDepartmentBtn.TabIndex = 0;
            this.CreateDepartmentBtn.Text = "Create";
            this.CreateDepartmentBtn.UseVisualStyleBackColor = true;
            this.CreateDepartmentBtn.Click += new System.EventHandler(this.CreateDepartmentBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.AcceptsTab = true;
            this.NameTxtBox.Location = new System.Drawing.Point(74, 6);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.NameTxtBox.TabIndex = 2;
            // 
            // DescriptionTxtBox
            // 
            this.DescriptionTxtBox.AcceptsTab = true;
            this.DescriptionTxtBox.Location = new System.Drawing.Point(74, 32);
            this.DescriptionTxtBox.Name = "DescriptionTxtBox";
            this.DescriptionTxtBox.Size = new System.Drawing.Size(100, 20);
            this.DescriptionTxtBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // NewDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 101);
            this.Controls.Add(this.DescriptionTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateDepartmentBtn);
            this.Name = "NewDepartment";
            this.Text = "NewDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateDepartmentBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox DescriptionTxtBox;
        private System.Windows.Forms.Label label2;
    }
}