using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rrhh.Migrations;
using Rrhh.Models;

namespace Rrhh.Controllers
{
    public class JobsController : BaseController
    {
        
        public JobsController(RrhhContext context) : base(context, context.Jobs)
        {
        }

        public Job New(Department department, string name, string description)
        {
            return new Job {Department = department, Name = name, Description = description};
        }

        public Job Create(string name, string description, Department department)
        {
            var newJob = New(department, name, description);
            DoCreate(newJob);
            return newJob;
        }

        public IEnumerable<Job> List()
        {
            return Context.Jobs.ToList();
        }
    }
}
