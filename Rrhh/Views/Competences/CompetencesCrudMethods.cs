using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Views.Candidates;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Competences
{
    public class CompetencesCrudMethods : CrudMethods
    {
        public CompetencesCrudMethods(RrhhContext context, ViewContext viewContext)
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
            return null;
        }

        protected override Func<BaseModel> ConstructCreateFunction()
        {
            return () =>
            {
                var view = new NewCompetence();
                view.ShowDialog();
                return view.Model;
            };
        }
    }
}
