using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Rrhh.Controllers;
using Rrhh.Models;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Employees
{
    public partial class EditEmployee : BaseView
    {
        public Employee Employee { get; set; }
        public IEnumerable<Employee> Employees { get; }
        public EmployeesController Controller { get; }
        private bool _employeeGiven = false;

        public EditEmployee(ViewContext viewContext, EmployeesController controller, Employee employee)
        {
            InitializeComponent();
            Controller = controller;
            ViewContext = viewContext;
            Employees = Controller.ListEmployees().ToList();
            Employee = employee;
            LoadEmployee();
        }

        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            Employee.FirstName = FirstNameTxtBox.Text;
            Employee.LastName = LastNameTxtBox.Text;
            Employee.GovernmentIssuedId = SocialIdTxtBox.Text;
            Employee.Salary = decimal.Parse(SalaryTxtBox.Text);
            Employee.Email = EmailTxtBox.Text;
            Employee.Phone = PhoneNumberTxtBox.Text;
            Controller.Update(Employee);
            //ViewContext.AddErrors(Employee);
            Close();
        }

        //private void SelectAnEmployeeBtn_Click(object sender, EventArgs e)
        //{
        //    var dialog = new RowSelector(new BindingSource {DataSource = Employees});
        //    dialog.ShowDialog();
        //    Employee = dialog.SelectedItem as Employee;
        //    if(Employee != null) LoadEmployee();
        //}

        private void LoadEmployee()
        {
            FirstNameTxtBox.Text = Employee.FirstName;
            LastNameTxtBox.Text = Employee.LastName;
            SocialIdTxtBox.Text = Employee.GovernmentIssuedId;
            SalaryTxtBox.Text = Employee.Salary.ToString();
            EmailTxtBox.Text = Employee.Email;
            PhoneNumberTxtBox.Text = Employee.Phone;
        }
    }
}
