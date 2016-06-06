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
            ((System.ComponentModel.ISupportInitialize)(this.ModelsList)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(314, 65);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(113, 23);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Delete selected";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(178, 65);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(103, 23);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "Edit selected";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ModelsList
            // 
            this.ModelsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.ModelsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.ModelsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModelsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ModelsList.Location = new System.Drawing.Point(0, 112);
            this.ModelsList.MultiSelect = false;
            this.ModelsList.Name = "ModelsList";
            this.ModelsList.ReadOnly = true;
            this.ModelsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ModelsList.Size = new System.Drawing.Size(678, 365);
            this.ModelsList.TabIndex = 3;
            // 
            // createNewButton
            // 
            this.createNewButton.Location = new System.Drawing.Point(44, 65);
            this.createNewButton.Name = "createNewButton";
            this.createNewButton.Size = new System.Drawing.Size(103, 23);
            this.createNewButton.TabIndex = 6;
            this.createNewButton.Text = "Create new";
            this.createNewButton.UseVisualStyleBackColor = true;
            this.createNewButton.Click += new System.EventHandler(this.createNewButton_Click);
            // 
            // CrudModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 477);
            this.Controls.Add(this.createNewButton);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.ModelsList);
            this.Name = "CrudModels";
            this.Text = "CrudModels";
            ((System.ComponentModel.ISupportInitialize)(this.ModelsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.DataGridView ModelsList;
        private System.Windows.Forms.Button createNewButton;
    }
}