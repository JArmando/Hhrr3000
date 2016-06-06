using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rrhh.Controllers;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Views.Candidates;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Employees
{
    public class CrudEmployeesMethods : CrudMethods
    {
        public CrudEmployeesMethods(RrhhContext context, ViewContext viewContext)
        {
            Context = context;
            ViewContext = viewContext;
        }
        protected override Func<BaseModel, BaseModel> ConstructEditFunction()
        {
            return (x) =>
            {
                var view = new EditEmployee(ViewContext, new EmployeesController(Context), x as Employee);
                view.ShowDialog();
                return x;
            };
        }

        protected override Func<BaseModel, bool> ConstructDeleteFunction()
        {
            return x =>
            {
                var view = MessageBox.Show(null, "Are you sure you want to delete this?", "WARNING", MessageBoxButtons.YesNo);
                var result = false;

                if (view != DialogResult.Yes) return result;

                var employee = x as Employee;
                result = EmployeesController.Delete(Context, employee);
                if (employee != null) ViewContext.AddErrors($"Employee {employee.FirstName} deleted");
                return result;
            };
        }

        protected override Func<BaseModel> ConstructCreateFunction()
        {
            return () =>
            {
                var view = new NewEmployeeView(ViewContext, new EmployeesController(Context));
                view.ShowDialog();
                return view.Employee;
            };
        }
    }
}
