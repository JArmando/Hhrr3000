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
    public class JobsController
    {
        public RrhhContext Context { get; }
        private DbSet dbset { get; }

        public JobsController(RrhhContext context)
        {
            Context = context;
            dbset = context.Jobs;
        }

        public Job New(Department department, string name)
        {
            return new Job {Department = department, Name = name};
        }

        public Job Create(string name, string description, Department department)
        {
            var newJob = New(department, name);
            SaveChanges(newJob);
            return newJob;
        }

        private void SaveChanges(BaseModel model)
        {
            dbset.Add(model);
            Context.SaveChanges();
        }
    }
}
