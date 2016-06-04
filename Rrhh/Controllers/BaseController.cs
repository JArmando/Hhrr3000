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
    public abstract class BaseController
    {
        internal RrhhContext Context;
        internal DbSet Dbset;

        internal BaseController(RrhhContext context, DbSet dbSet)
        {
            Context = context;
            Dbset = dbSet;
        }

        public bool DoCreate(BaseModel model)
        {
            if (!model.IsValid()) return false;
            Dbset.Add(model);
            Context.SaveChanges();
            return true;
        }
    }
}
