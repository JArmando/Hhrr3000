using System.Linq;
using Rrhh.Controllers;
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

    }
}
