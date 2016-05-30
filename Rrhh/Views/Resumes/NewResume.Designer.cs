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
            this.label1 = new System.Windows.Forms.Label();
            this.competencesGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.languagesGrid = new System.Windows.Forms.DataGridView();
            this.AddCompetenceBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competencesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddCompetenceBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.languagesGrid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.competencesGrid);
            this.groupBox1.Location = new System.Drawing.Point(38, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Competencias";
            // 
            // competencesGrid
            // 
            this.competencesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.competencesGrid.Location = new System.Drawing.Point(29, 149);
            this.competencesGrid.Name = "competencesGrid";
            this.competencesGrid.Size = new System.Drawing.Size(240, 150);
            this.competencesGrid.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Idiomas";
            // 
            // languagesGrid
            // 
            this.languagesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.languagesGrid.Location = new System.Drawing.Point(300, 149);
            this.languagesGrid.Name = "languagesGrid";
            this.languagesGrid.Size = new System.Drawing.Size(240, 150);
            this.languagesGrid.TabIndex = 2;
            // 
            // AddCompetenceBtn
            // 
            this.AddCompetenceBtn.Location = new System.Drawing.Point(189, 305);
            this.AddCompetenceBtn.Name = "AddCompetenceBtn";
            this.AddCompetenceBtn.Size = new System.Drawing.Size(80, 33);
            this.AddCompetenceBtn.TabIndex = 4;
            this.AddCompetenceBtn.Text = "Agregar";
            this.AddCompetenceBtn.UseVisualStyleBackColor = true;
            this.AddCompetenceBtn.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // NewResume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 515);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewResume";
            this.Text = "NewResume";
            this.Load += new System.EventHandler(this.NewResume_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competencesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView competencesGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCompetenceBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView languagesGrid;
    }
}