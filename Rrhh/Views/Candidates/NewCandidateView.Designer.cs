namespace Rrhh.Views
{
    partial class NewCandidateView
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
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneNumberTxtBox = new System.Windows.Forms.TextBox();
            this.AddCandidateBtn = new System.Windows.Forms.Button();
            this.AttachResumeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Location = new System.Drawing.Point(52, 102);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLbl.TabIndex = 0;
            this.FirstNameLbl.Text = "First Name";
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Location = new System.Drawing.Point(133, 95);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name";
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.Location = new System.Drawing.Point(133, 121);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTxtBox.TabIndex = 3;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(52, 154);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Location = new System.Drawing.Point(133, 147);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(100, 20);
            this.EmailTxtBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phone number";
            // 
            // PhoneNumberTxtBox
            // 
            this.PhoneNumberTxtBox.Location = new System.Drawing.Point(133, 176);
            this.PhoneNumberTxtBox.Name = "PhoneNumberTxtBox";
            this.PhoneNumberTxtBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneNumberTxtBox.TabIndex = 7;
            // 
            // AddCandidateBtn
            // 
            this.AddCandidateBtn.Location = new System.Drawing.Point(133, 211);
            this.AddCandidateBtn.Name = "AddCandidateBtn";
            this.AddCandidateBtn.Size = new System.Drawing.Size(100, 23);
            this.AddCandidateBtn.TabIndex = 8;
            this.AddCandidateBtn.Text = "Add candidate";
            this.AddCandidateBtn.UseVisualStyleBackColor = true;
            this.AddCandidateBtn.Click += new System.EventHandler(this.AddCandidateBtn_Click);
            // 
            // AttachResumeBtn
            // 
            this.AttachResumeBtn.Location = new System.Drawing.Point(298, 95);
            this.AttachResumeBtn.Name = "AttachResumeBtn";
            this.AttachResumeBtn.Size = new System.Drawing.Size(203, 139);
            this.AttachResumeBtn.TabIndex = 9;
            this.AttachResumeBtn.Text = "Attach Resume";
            this.AttachResumeBtn.UseVisualStyleBackColor = true;
            this.AttachResumeBtn.Click += new System.EventHandler(this.AttachResumeBtn_Click);
            // 
            // NewCandidateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 503);
            this.Controls.Add(this.AttachResumeBtn);
            this.Controls.Add(this.AddCandidateBtn);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.PhoneNumberTxtBox);
            this.Controls.Add(this.FirstNameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.LastNameTxtBox);
            this.Controls.Add(this.Email);
            this.Name = "NewCandidateView";
            this.Text = "NewCandidateView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AttachResumeBtn;
        private System.Windows.Forms.Button AddCandidateBtn;
        private System.Windows.Forms.TextBox PhoneNumberTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox LastNameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.Label FirstNameLbl;
    }
}