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
            this.FilterBtn = new System.Windows.Forms.Button();
            this.OmniSearchBox = new System.Windows.Forms.TextBox();
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
            this.CandidatesGrid.Location = new System.Drawing.Point(0, 109);
            this.CandidatesGrid.Name = "CandidatesGrid";
            this.CandidatesGrid.ReadOnly = true;
            this.CandidatesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CandidatesGrid.Size = new System.Drawing.Size(887, 360);
            this.CandidatesGrid.TabIndex = 0;
            // 
            // HireBtn
            // 
            this.HireBtn.Location = new System.Drawing.Point(310, 70);
            this.HireBtn.Name = "HireBtn";
            this.HireBtn.Size = new System.Drawing.Size(190, 28);
            this.HireBtn.TabIndex = 1;
            this.HireBtn.Text = "Hire selected candidates";
            this.HireBtn.UseVisualStyleBackColor = true;
            this.HireBtn.Click += new System.EventHandler(this.HireBtn_Click);
            // 
            // FilterBtn
            // 
            this.FilterBtn.Location = new System.Drawing.Point(434, 22);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(75, 23);
            this.FilterBtn.TabIndex = 2;
            this.FilterBtn.Text = "Filter!";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // OmniSearchBox
            // 
            this.OmniSearchBox.Location = new System.Drawing.Point(310, 22);
            this.OmniSearchBox.Name = "OmniSearchBox";
            this.OmniSearchBox.Size = new System.Drawing.Size(100, 20);
            this.OmniSearchBox.TabIndex = 3;
            // 
            // ListCandidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 469);
            this.Controls.Add(this.OmniSearchBox);
            this.Controls.Add(this.FilterBtn);
            this.Controls.Add(this.HireBtn);
            this.Controls.Add(this.CandidatesGrid);
            this.Name = "ListCandidates";
            this.Text = "ListCandidates";
            ((System.ComponentModel.ISupportInitialize)(this.CandidatesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CandidatesGrid;
        private System.Windows.Forms.Button HireBtn;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.TextBox OmniSearchBox;
    }
}