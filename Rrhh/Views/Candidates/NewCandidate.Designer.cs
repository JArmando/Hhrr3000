namespace Rrhh.Views
{
    partial class NewCandidate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddCandidateBtn = new System.Windows.Forms.Button();
            this.PhoneNumberTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.AttachResumeBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AttachResumeBtn);
            this.groupBox1.Controls.Add(this.AddCandidateBtn);
            this.groupBox1.Controls.Add(this.PhoneNumberTxtBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EmailTxtBox);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.LastNameTxtBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FirstNameTxtBox);
            this.groupBox1.Controls.Add(this.FirstNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(34, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // AddCandidateBtn
            // 
            this.AddCandidateBtn.Location = new System.Drawing.Point(135, 209);
            this.AddCandidateBtn.Name = "AddCandidateBtn";
            this.AddCandidateBtn.Size = new System.Drawing.Size(100, 23);
            this.AddCandidateBtn.TabIndex = 8;
            this.AddCandidateBtn.Text = "Add candidate";
            this.AddCandidateBtn.UseVisualStyleBackColor = true;
            this.AddCandidateBtn.Click += new System.EventHandler(this.AddCandidateBtn_Click);
            // 
            // PhoneNumberTxtBox
            // 
            this.PhoneNumberTxtBox.Location = new System.Drawing.Point(135, 174);
            this.PhoneNumberTxtBox.Name = "PhoneNumberTxtBox";
            this.PhoneNumberTxtBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneNumberTxtBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phone number";
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Location = new System.Drawing.Point(135, 145);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(100, 20);
            this.EmailTxtBox.TabIndex = 5;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(54, 152);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.Location = new System.Drawing.Point(135, 119);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTxtBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name";
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Location = new System.Drawing.Point(135, 93);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTxtBox.TabIndex = 1;
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Location = new System.Drawing.Point(54, 100);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLbl.TabIndex = 0;
            this.FirstNameLbl.Text = "First Name";
            // 
            // AttachResumeBtn
            // 
            this.AttachResumeBtn.Location = new System.Drawing.Point(215, 312);
            this.AttachResumeBtn.Name = "AttachResumeBtn";
            this.AttachResumeBtn.Size = new System.Drawing.Size(208, 88);
            this.AttachResumeBtn.TabIndex = 9;
            this.AttachResumeBtn.Text = "Attach Resume";
            this.AttachResumeBtn.UseVisualStyleBackColor = true;
            this.AttachResumeBtn.Click += new System.EventHandler(this.AttachResumeBtn_Click);
            // 
            // NewCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 503);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewCandidate";
            this.Text = "NewCandidate";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox LastNameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Button AddCandidateBtn;
        private System.Windows.Forms.TextBox PhoneNumberTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AttachResumeBtn;
    }
}