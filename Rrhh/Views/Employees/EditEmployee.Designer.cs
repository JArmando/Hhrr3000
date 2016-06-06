namespace Rrhh.Views.Employees
{
    partial class EditEmployee
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
            this.label5 = new System.Windows.Forms.Label();
            this.DepartmentsCmbBox = new System.Windows.Forms.ComboBox();
            this.SalaryTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SocialIdTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveChangesBtn = new System.Windows.Forms.Button();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.PhoneNumberTxtBox = new System.Windows.Forms.TextBox();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.SelectAnEmployeeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Department";
            // 
            // DepartmentsCmbBox
            // 
            this.DepartmentsCmbBox.FormattingEnabled = true;
            this.DepartmentsCmbBox.Location = new System.Drawing.Point(104, 231);
            this.DepartmentsCmbBox.Name = "DepartmentsCmbBox";
            this.DepartmentsCmbBox.Size = new System.Drawing.Size(121, 21);
            this.DepartmentsCmbBox.TabIndex = 43;
            // 
            // SalaryTxtBox
            // 
            this.SalaryTxtBox.Location = new System.Drawing.Point(125, 205);
            this.SalaryTxtBox.Mask = "00000000";
            this.SalaryTxtBox.Name = "SalaryTxtBox";
            this.SalaryTxtBox.Size = new System.Drawing.Size(100, 20);
            this.SalaryTxtBox.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Salary";
            // 
            // SocialIdTxtBox
            // 
            this.SocialIdTxtBox.Location = new System.Drawing.Point(125, 178);
            this.SocialIdTxtBox.Name = "SocialIdTxtBox";
            this.SocialIdTxtBox.Size = new System.Drawing.Size(100, 20);
            this.SocialIdTxtBox.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Social ID";
            // 
            // SaveChangesBtn
            // 
            this.SaveChangesBtn.Location = new System.Drawing.Point(125, 271);
            this.SaveChangesBtn.Name = "SaveChangesBtn";
            this.SaveChangesBtn.Size = new System.Drawing.Size(100, 23);
            this.SaveChangesBtn.TabIndex = 38;
            this.SaveChangesBtn.Text = "Save changes";
            this.SaveChangesBtn.UseVisualStyleBackColor = true;
            this.SaveChangesBtn.Click += new System.EventHandler(this.SaveChangesBtn_Click);
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Location = new System.Drawing.Point(26, 74);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLbl.TabIndex = 30;
            this.FirstNameLbl.Text = "First Name";
            // 
            // PhoneNumberTxtBox
            // 
            this.PhoneNumberTxtBox.Location = new System.Drawing.Point(125, 152);
            this.PhoneNumberTxtBox.Name = "PhoneNumberTxtBox";
            this.PhoneNumberTxtBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneNumberTxtBox.TabIndex = 37;
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Location = new System.Drawing.Point(125, 71);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTxtBox.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Phone number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Last Name";
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Location = new System.Drawing.Point(125, 123);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(100, 20);
            this.EmailTxtBox.TabIndex = 35;
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.Location = new System.Drawing.Point(125, 97);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTxtBox.TabIndex = 33;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(26, 126);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 34;
            this.Email.Text = "Email";
            // 
            // SelectAnEmployeeBtn
            // 
            this.SelectAnEmployeeBtn.Location = new System.Drawing.Point(109, 12);
            this.SelectAnEmployeeBtn.Name = "SelectAnEmployeeBtn";
            this.SelectAnEmployeeBtn.Size = new System.Drawing.Size(116, 34);
            this.SelectAnEmployeeBtn.TabIndex = 45;
            this.SelectAnEmployeeBtn.Text = "Select an employee";
            this.SelectAnEmployeeBtn.UseVisualStyleBackColor = true;
            // 
            // ModifyEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 334);
            this.Controls.Add(this.SelectAnEmployeeBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DepartmentsCmbBox);
            this.Controls.Add(this.SalaryTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SocialIdTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveChangesBtn);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.PhoneNumberTxtBox);
            this.Controls.Add(this.FirstNameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.LastNameTxtBox);
            this.Controls.Add(this.Email);
            this.Name = "ModifyEmployee";
            this.Text = "ModifyEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DepartmentsCmbBox;
        private System.Windows.Forms.MaskedTextBox SalaryTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SocialIdTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveChangesBtn;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.TextBox PhoneNumberTxtBox;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.TextBox LastNameTxtBox;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button SelectAnEmployeeBtn;
    }
}