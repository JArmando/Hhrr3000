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
using Rrhh.Models;

namespace Rrhh.Views.Employees
{
    public partial class NewEmployeeView : Form
    {
        public Employee Employee { get; set; }
        private Resume Resume { get; set; }
        private EmployeesController Controller { get; }
        public NewEmployeeView(EmployeesController controller)
        {
            InitializeComponent();
            Controller = controller;
            //AddEmployeeBtn.Enabled = false;
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
            Employee = Controller.New(firstName, lastName, governmentIssuedId, email, phone, aspiringSalary, null);
        }
    }
}
