namespace Rrhh.Views.Resumes
{
    partial class NewResume
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
            this.AddLangBtn = new System.Windows.Forms.Button();
            this.AddCompetenceBtn = new System.Windows.Forms.Button();
            this.languagesGrid = new System.Windows.Forms.DataGridView();
            this.competencesGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languagesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competencesGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddCompetenceBtn);
            this.groupBox1.Controls.Add(this.competencesGrid);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Competencias";
            // 
            // AddLangBtn
            // 
            this.AddLangBtn.Location = new System.Drawing.Point(503, 45);
            this.AddLangBtn.Name = "AddLangBtn";
            this.AddLangBtn.Size = new System.Drawing.Size(80, 33);
            this.AddLangBtn.TabIndex = 5;
            this.AddLangBtn.Text = "Agregar";
            this.AddLangBtn.UseVisualStyleBackColor = true;
            this.AddLangBtn.Click += new System.EventHandler(this.AddLangBtn_Click);
            // 
            // AddCompetenceBtn
            // 
            this.AddCompetenceBtn.Location = new System.Drawing.Point(503, 44);
            this.AddCompetenceBtn.Name = "AddCompetenceBtn";
            this.AddCompetenceBtn.Size = new System.Drawing.Size(80, 33);
            this.AddCompetenceBtn.TabIndex = 4;
            this.AddCompetenceBtn.Text = "Agregar";
            this.AddCompetenceBtn.UseVisualStyleBackColor = true;
            this.AddCompetenceBtn.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // languagesGrid
            // 
            this.languagesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.languagesGrid.Location = new System.Drawing.Point(17, 21);
            this.languagesGrid.Name = "languagesGrid";
            this.languagesGrid.Size = new System.Drawing.Size(472, 77);
            this.languagesGrid.TabIndex = 2;
            // 
            // competencesGrid
            // 
            this.competencesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.competencesGrid.Location = new System.Drawing.Point(17, 19);
            this.competencesGrid.Name = "competencesGrid";
            this.competencesGrid.Size = new System.Drawing.Size(472, 76);
            this.competencesGrid.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.languagesGrid);
            this.groupBox2.Controls.Add(this.AddLangBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 115);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Idiomas";
            // 
            // NewResume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 286);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewResume";
            this.Text = "NewResume";
            this.Load += new System.EventHandler(this.NewResume_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.languagesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competencesGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView competencesGrid;
        private System.Windows.Forms.Button AddCompetenceBtn;
        private System.Windows.Forms.DataGridView languagesGrid;
        private System.Windows.Forms.Button AddLangBtn;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}