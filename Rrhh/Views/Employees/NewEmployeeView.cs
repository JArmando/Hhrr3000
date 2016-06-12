using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using Rrhh.Controllers;
using Rrhh.Models;
using Rrhh.Views.JobOffers;
using Rrhh.Views.Jobs;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Employees
{
    public partial class NewEmployeeView : BaseView
    {
        public Employee Employee { get; set; }
        private Resume Resume { get; set; }
        private Job Job { get; set; }
        private EmployeesController Controller { get; }
        public NewEmployeeView(ViewContext viewContext, EmployeesController controller) : base(viewContext)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            var firstName = FirstNameTxtBox.Text;
            var lastName = LastNameTxtBox.Text;
            var phone = PhoneNumberTxtBox.Text;
            var email = EmailTxtBox.Text;
            var governmentIssuedId = SocialIdTxtBox.Text;
            var aspiringSalary = decimal.Parse(SalaryTxtBox.Text);
            //var job = new Job();
            //Add logic to pick a job by department after I create the list of jobs
            Employee = Controller.Create(firstName, lastName, governmentIssuedId, email, phone, aspiringSalary, Job);
            ViewContext.AddErrors(Employee);
        }

        private void selectJobOfferBtn_Click(object sender, EventArgs e)
        {
            var bindingSource = new BindingSource { DataSource = Controller.Context.Jobs.ToList() };
            // please use the controller's list method
            var crud = new JobsCrudViews(Controller.Context, ViewContext);
            var dialog = new RowSelector(bindingSource, crud);
            dialog.ShowDialog();
            Job = dialog.SelectedItem as Job;
        }
    }
}
