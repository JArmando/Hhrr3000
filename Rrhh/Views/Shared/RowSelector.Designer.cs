namespace Rrhh.Views.Shared
{
    partial class RowSelector
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.CreateNewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(1, 104);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(592, 278);
            this.dataGridView.TabIndex = 0;
            // 
            // SelectBtn
            // 
            this.SelectBtn.Location = new System.Drawing.Point(300, 36);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(172, 48);
            this.SelectBtn.TabIndex = 1;
            this.SelectBtn.Text = "Use selected";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // CreateNewBtn
            // 
            this.CreateNewBtn.Location = new System.Drawing.Point(84, 36);
            this.CreateNewBtn.Name = "CreateNewBtn";
            this.CreateNewBtn.Size = new System.Drawing.Size(172, 48);
            this.CreateNewBtn.TabIndex = 2;
            this.CreateNewBtn.Text = "Create new";
            this.CreateNewBtn.UseVisualStyleBackColor = true;
            this.CreateNewBtn.Click += new System.EventHandler(this.CreateNewBtn_Click);
            // 
            // RowSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 439);
            this.Controls.Add(this.CreateNewBtn);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.dataGridView);
            this.Name = "RowSelector";
            this.Text = "JobSelector";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button SelectBtn;
        private System.Windows.Forms.Button CreateNewBtn;
    }
}