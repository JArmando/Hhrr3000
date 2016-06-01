namespace Rrhh.Views.Employees
{
    partial class NewEmployeeView
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
            this.SalaryTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SocialIdTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AttachResumeBtn = new System.Windows.Forms.Button();
            this.AddEmployeeBtn = new System.Windows.Forms.Button();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.PhoneNumberTxtBox = new System.Windows.Forms.TextBox();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.DepartmentsCmbBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SalaryTxtBox
            // 
            this.SalaryTxtBox.Location = new System.Drawing.Point(114, 150);
            this.SalaryTxtBox.Mask = "00000000";
            this.SalaryTxtBox.Name = "SalaryTxtBox";
            this.SalaryTxtBox.Size = new System.Drawing.Size(100, 20);
            this.SalaryTxtBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Salary";
            // 
            // SocialIdTxtBox
            // 
            this.SocialIdTxtBox.Location = new System.Drawing.Point(114, 123);
            this.SocialIdTxtBox.Name = "SocialIdTxtBox";
            this.SocialIdTxtBox.Size = new System.Drawing.Size(100, 20);
            this.SocialIdTxtBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Social ID";
            // 
            // AttachResumeBtn
            // 
            this.AttachResumeBtn.Location = new System.Drawing.Point(261, 12);
            this.AttachResumeBtn.Name = "AttachResumeBtn";
            this.AttachResumeBtn.Size = new System.Drawing.Size(203, 139);
            this.AttachResumeBtn.TabIndex = 23;
            this.AttachResumeBtn.Text = "Attach Resume";
            this.AttachResumeBtn.UseVisualStyleBackColor = true;
            // 
            // AddEmployeeBtn
            // 
            this.AddEmployeeBtn.Location = new System.Drawing.Point(114, 216);
            this.AddEmployeeBtn.Name = "AddEmployeeBtn";
            this.AddEmployeeBtn.Size = new System.Drawing.Size(100, 23);
            this.AddEmployeeBtn.TabIndex = 22;
            this.AddEmployeeBtn.Text = "Add Employee";
            this.AddEmployeeBtn.UseVisualStyleBackColor = true;
            this.AddEmployeeBtn.Click += new System.EventHandler(this.AddEmployeeBtn_Click);
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Location = new System.Drawing.Point(15, 19);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLbl.TabIndex = 14;
            this.FirstNameLbl.Text = "First Name";
            // 
            // PhoneNumberTxtBox
            // 
            this.PhoneNumberTxtBox.Location = new System.Drawing.Point(114, 97);
            this.PhoneNumberTxtBox.Name = "PhoneNumberTxtBox";
            this.PhoneNumberTxtBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneNumberTxtBox.TabIndex = 21;
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Location = new System.Drawing.Point(114, 16);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTxtBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Phone number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Last Name";
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Location = new System.Drawing.Point(114, 68);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(100, 20);
            this.EmailTxtBox.TabIndex = 19;
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.Location = new System.Drawing.Point(114, 42);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTxtBox.TabIndex = 17;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(15, 71);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 18;
            this.Email.Text = "Email";
            // 
            // DepartmentsCmbBox
            // 
            this.DepartmentsCmbBox.FormattingEnabled = true;
            this.DepartmentsCmbBox.Location = new System.Drawing.Point(93, 176);
            this.DepartmentsCmbBox.Name = "DepartmentsCmbBox";
            this.DepartmentsCmbBox.Size = new System.Drawing.Size(121, 21);
            this.DepartmentsCmbBox.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Department";
            // 
            // NewEmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 352);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DepartmentsCmbBox);
            this.Controls.Add(this.SalaryTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SocialIdTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AttachResumeBtn);
            this.Controls.Add(this.AddEmployeeBtn);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.PhoneNumberTxtBox);
            this.Controls.Add(this.FirstNameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.LastNameTxtBox);
            this.Controls.Add(this.Email);
            this.Name = "NewEmployeeView";
            this.Text = "NewEmployeeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox SalaryTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SocialIdTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AttachResumeBtn;
        private System.Windows.Forms.Button AddEmployeeBtn;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.TextBox PhoneNumberTxtBox;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.TextBox LastNameTxtBox;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.ComboBox DepartmentsCmbBox;
        private System.Windows.Forms.Label label5;
    }
}