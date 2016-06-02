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
            this.HireBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CandidatesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CandidatesGrid
            // 
            this.CandidatesGrid.AllowUserToAddRows = false;
            this.CandidatesGrid.AllowUserToDeleteRows = false;
            this.CandidatesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.CandidatesGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.CandidatesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CandidatesGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CandidatesGrid.Location = new System.Drawing.Point(0, 180);
            this.CandidatesGrid.Name = "CandidatesGrid";
            this.CandidatesGrid.ReadOnly = true;
            this.CandidatesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CandidatesGrid.Size = new System.Drawing.Size(887, 360);
            this.CandidatesGrid.TabIndex = 0;
            // 
            // HireBtn
            // 
            this.HireBtn.Location = new System.Drawing.Point(308, 97);
            this.HireBtn.Name = "HireBtn";
            this.HireBtn.Size = new System.Drawing.Size(190, 77);
            this.HireBtn.TabIndex = 1;
            this.HireBtn.Text = "Hire selected candidates";
            this.HireBtn.UseVisualStyleBackColor = true;
            this.HireBtn.Click += new System.EventHandler(this.HireBtn_Click);
            // 
            // ListCandidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 540);
            this.Controls.Add(this.HireBtn);
            this.Controls.Add(this.CandidatesGrid);
            this.Name = "ListCandidates";
            this.Text = "ListCandidates";
            ((System.ComponentModel.ISupportInitialize)(this.CandidatesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CandidatesGrid;
        private System.Windows.Forms.Button HireBtn;
    }
}