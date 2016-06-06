using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rrhh.Migrations;
using Rrhh.Models;

namespace Rrhh.Controllers
{
    public class DepartmentsController
    {
        public RrhhContext Context { get; }
        public DepartmentsController(RrhhContext context)
        {
            Context = context;
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

        public IEnumerable<Department> List()
        {
            return Context.Departments.ToList();
        }
    }
}
