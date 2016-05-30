namespace Rrhh.Views.JobOffers
{
    partial class NewJobOffer
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RiskLevelsCmbBox = new System.Windows.Forms.ComboBox();
            this.MinSalaryTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MaxSalaryTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.DescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(204, 131);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.NameTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Risk level";
            // 
            // RiskLevelsCmbBox
            // 
            this.RiskLevelsCmbBox.FormattingEnabled = true;
            this.RiskLevelsCmbBox.Location = new System.Drawing.Point(204, 161);
            this.RiskLevelsCmbBox.Name = "RiskLevelsCmbBox";
            this.RiskLevelsCmbBox.Size = new System.Drawing.Size(121, 21);
            this.RiskLevelsCmbBox.TabIndex = 3;
            // 
            // MinSalaryTxtBox
            // 
            this.MinSalaryTxtBox.Location = new System.Drawing.Point(204, 189);
            this.MinSalaryTxtBox.Mask = "RD$000,000,000.00";
            this.MinSalaryTxtBox.Name = "MinSalaryTxtBox";
            this.MinSalaryTxtBox.Size = new System.Drawing.Size(100, 20);
            this.MinSalaryTxtBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Min Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Max Salary";
            // 
            // MaxSalaryTxtBox
            // 
            this.MaxSalaryTxtBox.Location = new System.Drawing.Point(204, 215);
            this.MaxSalaryTxtBox.Mask = "RD$000,000,000.00";
            this.MaxSalaryTxtBox.Name = "MaxSalaryTxtBox";
            this.MaxSalaryTxtBox.Size = new System.Drawing.Size(100, 20);
            this.MaxSalaryTxtBox.TabIndex = 6;
            // 
            // DescriptionTxtBox
            // 
            this.DescriptionTxtBox.Location = new System.Drawing.Point(204, 241);
            this.DescriptionTxtBox.Name = "DescriptionTxtBox";
            this.DescriptionTxtBox.Size = new System.Drawing.Size(100, 20);
            this.DescriptionTxtBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(229, 292);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 10;
            this.OkButton.Text = "Create";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // NewJobOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 456);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.DescriptionTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaxSalaryTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MinSalaryTxtBox);
            this.Controls.Add(this.RiskLevelsCmbBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "NewJobOffer";
            this.Text = "NewJobOffer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RiskLevelsCmbBox;
        private System.Windows.Forms.MaskedTextBox MinSalaryTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MaxSalaryTxtBox;
        private System.Windows.Forms.TextBox DescriptionTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OkButton;
    }
}