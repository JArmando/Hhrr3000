namespace Rrhh.Views.Candidates
{
    partial class ListCandidates
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
            this.CandidatesGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CandidatesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CandidatesGrid
            // 
            this.CandidatesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CandidatesGrid.Location = new System.Drawing.Point(135, 93);
            this.CandidatesGrid.Name = "CandidatesGrid";
            this.CandidatesGrid.Size = new System.Drawing.Size(501, 249);
            this.CandidatesGrid.TabIndex = 0;
            // 
            // ListCandidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 418);
            this.Controls.Add(this.CandidatesGrid);
            this.Name = "ListCandidates";
            this.Text = "ListCandidates";
            ((System.ComponentModel.ISupportInitialize)(this.CandidatesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CandidatesGrid;
    }
}