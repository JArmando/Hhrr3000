using System;
using Rrhh.Controllers;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Views.Candidates;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Employees
{
    public class CrudEmployeesViews : CrudViews
    {
        public CrudEmployeesViews(RrhhContext dataContext, ViewContext viewContext) : base(dataContext, viewContext){}
        protected override Func<BaseModel, BaseModel> ConstructEditFunction()
        {
            return (x) =>
            {
                var view = new EditEmployee(ViewContext, new EmployeesController(DataContext), x as Employee);
                view.ShowDialog();
                return x;
            };
        }

        protected override Func<BaseModel, bool> ConstructDeleteFunction()
        {
            return x =>
            {
                if (YouAreNotSureYouWantToDeleteThis()) return false;
                var employee = x as Employee;
                var result = EmployeesController.Delete(DataContext, employee);
                if (employee != null) ViewContext.AddErrors($"Employee {employee.FirstName} deleted");
                return result;
            };
        }

        protected override Func<BaseModel, BaseModel> ConstructEspecialFunction()
        {
            return null;
        }

        protected override Func<BaseModel> ConstructCreateFunction()
        {
            return () =>
            {
                var view = new NewEmployeeView(ViewContext, new EmployeesController(DataContext));
                view.ShowDialog();
                return view.Employee;
            };
        }
    }
}
