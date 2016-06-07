﻿using System;
using System.Linq;
using System.Windows.Forms;
using Rrhh.Controllers;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Views.Departments;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Jobs
{
    public partial class EditJob : BaseView
    {
        private JobsController Controller;
        private RrhhContext Context => Controller.Context;
        public Department Department { get; set; }
        private Job Job;
        public EditJob(ViewContext viewContext, JobsController controller, Job job) : base(viewContext)
        {
            InitializeComponent();
            Controller = controller;
            Job = job;
            Department = Job.Department;
            LoadData();
        }

        private void selectDepartmentBtn_Click(object sender, EventArgs e)
        {
            var departments = new BindingSource { DataSource = Context.Departments.ToList() };
            var crud = new DepartmentsCrudMethods(Context, ViewContext);
            var dialog = new RowSelector(departments, crud);
            dialog.ShowDialog();
            Department = dialog.SelectedItem as Department;
            LoadData();
        }

        private void UpdateJobBtn_Click(object sender, EventArgs e)
        {
            Job.Name = NameTxtBox.Text;
            Job.Description = descriptionTxtBox.Text;
            Job.Department = Department;
            Controller.Update(Job);
            ViewContext.AddErrors(Job);
            Close();
        }

        private void LoadData()
        {
            NameTxtBox.Text = Job.Name;
            descriptionTxtBox.Text = Job.Description;
            if (Job.Department != null) DepartmentNameTxtBox.Text = Job.Department.Name;
        }
    }
}