namespace Rrhh.Views.Competences
{
    partial class NewCompetence
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
            this.AddCompetenceBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddCompetenceBtn
            // 
            this.AddCompetenceBtn.Location = new System.Drawing.Point(248, 213);
            this.AddCompetenceBtn.Name = "AddCompetenceBtn";
            this.AddCompetenceBtn.Size = new System.Drawing.Size(75, 23);
            this.AddCompetenceBtn.TabIndex = 0;
            this.AddCompetenceBtn.Text = "Add";
            this.AddCompetenceBtn.UseVisualStyleBackColor = true;
            this.AddCompetenceBtn.Click += new System.EventHandler(this.AddCompetenceBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(223, 143);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.NameTxtBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // DescriptionTxtBox
            // 
            this.DescriptionTxtBox.Location = new System.Drawing.Point(223, 170);
            this.DescriptionTxtBox.Name = "DescriptionTxtBox";
            this.DescriptionTxtBox.Size = new System.Drawing.Size(100, 20);
            this.DescriptionTxtBox.TabIndex = 4;
            // 
            // NewCompetence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 453);
            this.Controls.Add(this.DescriptionTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddCompetenceBtn);
            this.Name = "NewCompetence";
            this.Text = "NewCompetence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCompetenceBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescriptionTxtBox;
    }
}