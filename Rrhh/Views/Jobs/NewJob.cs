using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rrhh.Controllers;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Jobs
{
    public partial class NewJob : BaseView
    {
        public Department Department;
        private JobsController Controller;
        private RrhhContext Context => Controller.Context;

        public NewJob(ViewContext viewContext, JobsController controller) : base(viewContext)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void selectDepartmentBtn_Click(object sender, EventArgs e)
        {
            var departments = new BindingSource {DataSource = Context.Departments.ToList()};
            var dialog = new RowSelector(departments);
            dialog.ShowDialog();
            Department = dialog.SelectedItem as Department;
            dialog.Close();
        }

        private void CreateJobBtn_Click(object sender, EventArgs e)
        {
            var name = NameTxtBox.Text;
            var description = descriptionTxtBox.Text;
            var newJob = Controller.Create(name, description, Department);
            ViewContext.AddErrors(newJob);
        }
    }
}
