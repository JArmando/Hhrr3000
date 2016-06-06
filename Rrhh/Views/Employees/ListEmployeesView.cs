using System.Linq;
using Rrhh.Controllers;
using Rrhh.Models;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Employees
{
    public partial class ListEmployeesView : BaseView
    {
        private EmployeesController Controller { get; }

        public ListEmployeesView(ViewContext viewContext, EmployeesController controller) : base(viewContext)
        {
            InitializeComponent();
            Controller = controller;
            LoadData();
        }

        private void LoadData()
        {
            var context = Controller.Context;
            //please call on the controller's list method
            var employees = context.Employees;
            EmployeeList.DataSource = employees.ToList();
        }

        private void EditBtn_Click(object sender, System.EventArgs e)
        {
            var employee = EmployeeList.SelectedRows[0].DataBoundItem as Employee;
            //var dialog = new EditEmployee(employee);
            //dialog.ShowDialog();
            Controller.Update(employee);
            ViewContext.AddErrors(employee);
            EmployeeList.Refresh();
        }
    }
}
