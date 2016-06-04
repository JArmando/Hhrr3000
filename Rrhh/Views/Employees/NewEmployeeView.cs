using System;
using Rrhh.Controllers;
using Rrhh.Models;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Employees
{
    public partial class NewEmployeeView : BaseView
    {
        public Employee Employee { get; set; }
        private Resume Resume { get; set; }
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
            Employee = Controller.Create(firstName, lastName, governmentIssuedId, email, phone, aspiringSalary, null);
            ViewContext.AddErrors(Employee);
        }
    }
}
