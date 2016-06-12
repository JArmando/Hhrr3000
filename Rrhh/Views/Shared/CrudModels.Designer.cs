namespace Rrhh.Views.Shared
{
    partial class CrudModels
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
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ModelsList = new System.Windows.Forms.DataGridView();
            this.createNewButton = new System.Windows.Forms.Button();
            this.SpecialActionBtn = new System.Windows.Forms.Button();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ModelsList)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(314, 50);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(113, 23);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Delete selected";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(178, 50);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(103, 23);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "Edit selected";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ModelsList
            // 
            this.ModelsList.AllowUserToAddRows = false;
            this.ModelsList.AllowUserToDeleteRows = false;
            this.ModelsList.AllowUserToOrderColumns = true;
            this.ModelsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ModelsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ModelsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModelsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ModelsList.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModelsList.Location = new System.Drawing.Point(0, 112);
            this.ModelsList.MultiSelect = false;
            this.ModelsList.Name = "ModelsList";
            this.ModelsList.ReadOnly = true;
            this.ModelsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ModelsList.ShowEditingIcon = false;
            this.ModelsList.Size = new System.Drawing.Size(678, 365);
            this.ModelsList.TabIndex = 3;
            // 
            // createNewButton
            // 
            this.createNewButton.Location = new System.Drawing.Point(44, 50);
            this.createNewButton.Name = "createNewButton";
            this.createNewButton.Size = new System.Drawing.Size(103, 23);
            this.createNewButton.TabIndex = 6;
            this.createNewButton.Text = "Create new";
            this.createNewButton.UseVisualStyleBackColor = true;
            this.createNewButton.Click += new System.EventHandler(this.createNewButton_Click);
            // 
            // SpecialActionBtn
            // 
            this.SpecialActionBtn.Location = new System.Drawing.Point(454, 50);
            this.SpecialActionBtn.Name = "SpecialActionBtn";
            this.SpecialActionBtn.Size = new System.Drawing.Size(104, 23);
            this.SpecialActionBtn.TabIndex = 7;
            this.SpecialActionBtn.Text = "--";
            this.SpecialActionBtn.UseVisualStyleBackColor = true;
            this.SpecialActionBtn.Visible = false;
            this.SpecialActionBtn.Click += new System.EventHandler(this.SpecialActionBtn_Click);
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(45, 83);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(194, 20);
            this.SearchTxtBox.TabIndex = 8;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(260, 79);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 10;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // CrudModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 477);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTxtBox);
            this.Controls.Add(this.SpecialActionBtn);
            this.Controls.Add(this.createNewButton);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.ModelsList);
            this.Name = "CrudModels";
            this.Text = "CrudModels";
            ((System.ComponentModel.ISupportInitialize)(this.ModelsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.DataGridView ModelsList;
        private System.Windows.Forms.Button createNewButton;
        private System.Windows.Forms.Button SpecialActionBtn;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.Button SearchBtn;
    }
}