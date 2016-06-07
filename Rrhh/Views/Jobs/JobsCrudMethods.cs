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

namespace Rrhh.Views.Jobs
{
    public class JobsCrudMethods : CrudMethods
    {
        private JobsController Controller => new JobsController(Context);
        public JobsCrudMethods(RrhhContext context, ViewContext viewContext)
        {
            Context = context;
            ViewContext = viewContext;
        }

        protected override Func<BaseModel, BaseModel> ConstructEditFunction()
        {
            return (x) =>
            {
                var view = new EditJob(ViewContext, new JobsController(Context), x as Job);
                view.ShowDialog();
                return x;
            };
            //throw new NotImplementedException();
        }

        protected override Func<BaseModel, bool> ConstructDeleteFunction()
        {
            return x =>
            {
                var view = MessageBox.Show(null, "Are you sure you want to delete this?", "WARNING", MessageBoxButtons.YesNo);
                var result = false;

                if (view != DialogResult.Yes) return result;

                var job = x as Job;
                result = Controller.Delete(job);
                if (job != null) ViewContext.AddErrors($"Job {job.Name} deleted");
                return result;
            };
        }

        protected override Func<BaseModel> ConstructCreateFunction()
        {
            return () =>
            {
                var view = new NewJob(ViewContext, Controller);
                view.ShowDialog();
                var model = view.Job;
                return model;
            };
        }
    }
}
