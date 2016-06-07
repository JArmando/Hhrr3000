using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Rrhh.Migrations;
using Rrhh.Models;

namespace Rrhh.Controllers
{
    public class JobsController : BaseController<Job>
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

        public Job Update(Job job)
        {
            Context.Jobs.AddOrUpdate(job);
            Context.SaveChanges();
            return job;
        }

        public bool Delete(Job job)
        {
            DoDelete(job);
            return true;
        }

        public IEnumerable<Job> List()
        {
            return Context.Jobs.ToList();
        }
    }
}
