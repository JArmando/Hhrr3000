using System.Collections.Generic;
using System.Linq;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Presenters;

namespace Rrhh.Controllers
{
    public class DepartmentsController : BaseController<Department>
    {
        public DepartmentsController(RrhhContext context) : base(context, context.Departments)
        {
        }

        public Department New(string name, string description)
        {
            return new Department { Name = name, Description = description};
        }

        public Department Create(string name, string description)
        {
            var department = New(name, description);
            if (department.IsValid())
            {
                Context.Departments.Add(department);
                Context.SaveChanges();
            }
            
            return department;
        }

        public static bool Delete(RrhhContext context, Department department)
        {
            return new DepartmentsController(context).Delete(department);
        }

        public bool Delete(Department department)
        {
            return DoDelete(department);
        }

        public IEnumerable<Department> List()
        {
            return Context.Departments.ToList();
        }

        public IEnumerable<PresentedModel> Filter(string s)
        {
            var result = Dbset.Where(x => 
                x.Name.Contains(s) ||
                x.Description.Contains(s)
            );
            return new DepartmentsPresenter(result).Models;
        }
    }
}
