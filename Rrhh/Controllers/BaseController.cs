using System.Data.Entity;
using System.Data.Entity.Migrations;
using Rrhh.Migrations;
using Rrhh.Models;

namespace Rrhh.Controllers
{
    public abstract class BaseController<T> where T : BaseModel
    {
        internal RrhhContext Context;
        internal DbSet<T> Dbset;

        internal BaseController(RrhhContext context, DbSet<T> dbSet) 
        {
            Context = context;
            Dbset = dbSet;
        }

        public bool DoCreate(T model)
        {
            if (!model.IsValid()) return false;
            Dbset.Add(model);
            Context.SaveChanges();
            return true;
        }

        public bool DoDelete(T model)
        {
            model.IsActive = false;
            DoUpdate(model);
            return true;
        }

        public bool DoUpdate(T model)
        {
            Dbset.AddOrUpdate(model);
            Context.SaveChanges();
            return true;
        }
    }
}
