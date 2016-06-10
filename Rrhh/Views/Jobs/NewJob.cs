using System;
using System.Linq;
using System.Windows.Forms;
using Rrhh.Controllers;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Views.Departments;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Jobs
{
    public partial class NewJob : BaseView
    {
        public Department Department;
        public Job Job;
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
            var crud = new DepartmentsCrudViews(Context, ViewContext);
            var dialog = new RowSelector(departments, crud);
            dialog.ShowDialog();
            Department = dialog.SelectedItem as Department;
            dialog.Close();
        }

        private void CreateJobBtn_Click(object sender, EventArgs e)
        {
            var name = NameTxtBox.Text;
            var description = descriptionTxtBox.Text;
            var newJob = Controller.Create(name, description, Department);
            Job = newJob;
        }
    }
}
