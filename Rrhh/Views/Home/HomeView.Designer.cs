namespace Rrhh.Views.Home
{
    partial class HomeView
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.MainCandidatesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewCandidateBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ListCandidatesBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.batidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeNewToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.TheBox = new System.Windows.Forms.GroupBox();
            this.EmployeeListToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.topMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(0, 24);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(903, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // topMenu
            // 
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainCandidatesMenu,
            this.batidaToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(903, 24);
            this.topMenu.TabIndex = 1;
            this.topMenu.Text = "menuStrip1";
            // 
            // MainCandidatesMenu
            // 
            this.MainCandidatesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewCandidateBtn,
            this.ListCandidatesBtn});
            this.MainCandidatesMenu.Name = "MainCandidatesMenu";
            this.MainCandidatesMenu.Size = new System.Drawing.Size(78, 20);
            this.MainCandidatesMenu.Text = "Candidates";
            // 
            // AddNewCandidateBtn
            // 
            this.AddNewCandidateBtn.Name = "AddNewCandidateBtn";
            this.AddNewCandidateBtn.Size = new System.Drawing.Size(152, 22);
            this.AddNewCandidateBtn.Text = "Add new";
            this.AddNewCandidateBtn.Click += new System.EventHandler(this.AddNewCandidateBtn_Click);
            // 
            // ListCandidatesBtn
            // 
            this.ListCandidatesBtn.Name = "ListCandidatesBtn";
            this.ListCandidatesBtn.Size = new System.Drawing.Size(152, 22);
            this.ListCandidatesBtn.Text = "List";
            this.ListCandidatesBtn.Click += new System.EventHandler(this.ListCandidatesBtn_Click);
            // 
            // batidaToolStripMenuItem
            // 
            this.batidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seMatoToolStripMenuItem});
            this.batidaToolStripMenuItem.Name = "batidaToolStripMenuItem";
            this.batidaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.batidaToolStripMenuItem.Text = "batida";
            // 
            // seMatoToolStripMenuItem
            // 
            this.seMatoToolStripMenuItem.Name = "seMatoToolStripMenuItem";
            this.seMatoToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.seMatoToolStripMenuItem.Text = "se mato";
            // 
            // TheBox
            // 
            this.TheBox.Location = new System.Drawing.Point(22, 51);
            this.TheBox.Name = "TheBox";
            this.TheBox.Size = new System.Drawing.Size(855, 443);
            this.TheBox.TabIndex = 2;
            this.TheBox.TabStop = false;
            this.TheBox.Text = "TheBox";
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 534);
            this.Controls.Add(this.TheBox);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.topMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "HomeView";
            this.Text = "HomeView";
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem MainCandidatesMenu;
        private System.Windows.Forms.ToolStripMenuItem AddNewCandidateBtn;
        private System.Windows.Forms.ToolStripMenuItem ListCandidatesBtn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem batidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seMatoToolStripMenuItem;
        private System.Windows.Forms.GroupBox TheBox;
    }
}