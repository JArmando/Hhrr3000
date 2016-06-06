using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rrhh.Controllers;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Views.Candidates;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Departments
{
    public class DepartmentsCrudMethods : CrudMethods
    {
        public DepartmentsCrudMethods(RrhhContext context, ViewContext viewContext)
        {
            Context = context;
            ViewContext = viewContext;
        }

        protected override Func<BaseModel, BaseModel> ConstructEditFunction()
        {
            throw new NotImplementedException();
        }

        protected override Func<BaseModel, bool> ConstructDeleteFunction()
        {
            throw new NotImplementedException();
        }

        protected override Func<BaseModel> ConstructCreateFunction()
        {
            return () =>
            {
                var view = new NewDepartment(ViewContext, new DepartmentsController(Context));
                view.ShowDialog();
                return view.Department;
            };
        }
    }
}
