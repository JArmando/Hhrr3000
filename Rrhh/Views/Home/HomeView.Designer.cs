﻿namespace Rrhh.Views.Home
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
            this.EmployeeListToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobOffersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createJobOfferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TheBox = new System.Windows.Forms.GroupBox();
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.languagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.batidaToolStripMenuItem,
            this.jobOffersToolStripMenuItem,
            this.departmentsToolStripMenuItem,
            this.languagesToolStripMenuItem});
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
            this.AddNewCandidateBtn.Size = new System.Drawing.Size(121, 22);
            this.AddNewCandidateBtn.Text = "Add new";
            this.AddNewCandidateBtn.Click += new System.EventHandler(this.AddNewCandidateBtn_Click);
            // 
            // ListCandidatesBtn
            // 
            this.ListCandidatesBtn.Name = "ListCandidatesBtn";
            this.ListCandidatesBtn.Size = new System.Drawing.Size(121, 22);
            this.ListCandidatesBtn.Text = "List";
            this.ListCandidatesBtn.Click += new System.EventHandler(this.ListCandidatesBtn_Click);
            // 
            // batidaToolStripMenuItem
            // 
            this.batidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployeeNewToolStrip,
            this.EmployeeListToolStrip,
            this.modifyToolStripMenuItem});
            this.batidaToolStripMenuItem.Name = "batidaToolStripMenuItem";
            this.batidaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.batidaToolStripMenuItem.Text = "Employees";
            // 
            // EmployeeNewToolStrip
            // 
            this.EmployeeNewToolStrip.Name = "EmployeeNewToolStrip";
            this.EmployeeNewToolStrip.Size = new System.Drawing.Size(133, 22);
            this.EmployeeNewToolStrip.Text = "Create new";
            this.EmployeeNewToolStrip.Click += new System.EventHandler(this.EmployeeNewToolStrip_Click);
            // 
            // EmployeeListToolStrip
            // 
            this.EmployeeListToolStrip.Name = "EmployeeListToolStrip";
            this.EmployeeListToolStrip.Size = new System.Drawing.Size(133, 22);
            this.EmployeeListToolStrip.Text = "List";
            this.EmployeeListToolStrip.Click += new System.EventHandler(this.EmployeeListToolStrip_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // jobOffersToolStripMenuItem
            // 
            this.jobOffersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createJobOfferToolStripMenuItem,
            this.createJobToolStripMenuItem,
            this.listToolStripMenuItem});
            this.jobOffersToolStripMenuItem.Name = "jobOffersToolStripMenuItem";
            this.jobOffersToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.jobOffersToolStripMenuItem.Text = "Jobs";
            // 
            // createJobOfferToolStripMenuItem
            // 
            this.createJobOfferToolStripMenuItem.Name = "createJobOfferToolStripMenuItem";
            this.createJobOfferToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.createJobOfferToolStripMenuItem.Text = "Create Job Offer";
            this.createJobOfferToolStripMenuItem.Click += new System.EventHandler(this.createJobOfferToolStripMenuItem_Click);
            // 
            // createJobToolStripMenuItem
            // 
            this.createJobToolStripMenuItem.Name = "createJobToolStripMenuItem";
            this.createJobToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.createJobToolStripMenuItem.Text = "Create job";
            this.createJobToolStripMenuItem.Click += new System.EventHandler(this.createJobToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDepartmentToolStripMenuItem,
            this.listToolStripMenuItem1});
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.departmentsToolStripMenuItem.Text = "Departments";
            // 
            // createDepartmentToolStripMenuItem
            // 
            this.createDepartmentToolStripMenuItem.Name = "createDepartmentToolStripMenuItem";
            this.createDepartmentToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.createDepartmentToolStripMenuItem.Text = "Create department";
            this.createDepartmentToolStripMenuItem.Click += new System.EventHandler(this.createDepartmentToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem1
            // 
            this.listToolStripMenuItem1.Name = "listToolStripMenuItem1";
            this.listToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.listToolStripMenuItem1.Text = "List";
            this.listToolStripMenuItem1.Click += new System.EventHandler(this.listToolStripMenuItem1_Click);
            // 
            // TheBox
            // 
            this.TheBox.AutoSize = true;
            this.TheBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TheBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TheBox.Location = new System.Drawing.Point(0, 529);
            this.TheBox.Name = "TheBox";
            this.TheBox.Size = new System.Drawing.Size(903, 5);
            this.TheBox.TabIndex = 2;
            this.TheBox.TabStop = false;
            this.TheBox.Text = "TheBox";
            // 
            // InfoBox
            // 
            this.InfoBox.BackColor = System.Drawing.SystemColors.Control;
            this.InfoBox.Location = new System.Drawing.Point(12, 51);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(485, 38);
            this.InfoBox.TabIndex = 0;
            this.InfoBox.Text = "";
            // 
            // languagesToolStripMenuItem
            // 
            this.languagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem});
            this.languagesToolStripMenuItem.Name = "languagesToolStripMenuItem";
            this.languagesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.languagesToolStripMenuItem.Text = "Languages";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addNewToolStripMenuItem.Text = "Add new";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 534);
            this.Controls.Add(this.InfoBox);
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
        private System.Windows.Forms.ToolStripMenuItem EmployeeNewToolStrip;
        private System.Windows.Forms.GroupBox TheBox;
        private System.Windows.Forms.ToolStripMenuItem EmployeeListToolStrip;
        private System.Windows.Forms.RichTextBox InfoBox;
        private System.Windows.Forms.ToolStripMenuItem jobOffersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createJobOfferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem languagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
    }
}