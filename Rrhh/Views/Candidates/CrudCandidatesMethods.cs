using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rrhh.Controllers;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Candidates
{
    public abstract class CrudMethods
    {
        public Func<BaseModel> Create => ConstructCreateFunction();
        public Func<BaseModel, BaseModel> Edit => ConstructEditFunction();
        public Func<BaseModel, bool> Delete => ConstructDeleteFunction();
        protected RrhhContext Context { get; set; }
        protected ViewContext ViewContext { get; set; }
        protected abstract Func<BaseModel, BaseModel> ConstructEditFunction();
        protected abstract Func<BaseModel, bool> ConstructDeleteFunction();

        protected abstract Func<BaseModel> ConstructCreateFunction();
    }

    public class CrudCandidatesMethods : CrudMethods
    {

        private readonly string _notImplementedActionMessage = "This action is not yet implemented";

        public CrudCandidatesMethods(RrhhContext context, ViewContext viewContext)
        {
            Context = context;
            ViewContext = viewContext;
        }

        protected override Func<BaseModel> ConstructCreateFunction()
        {
            return () =>
            {
                var view = new NewCandidateView(ViewContext, new CandidatesController(Context));
                view.ShowDialog();
                var result = view.Model;
                ViewContext.AddErrors(result);
                return result;
            };
        }

        protected override Func<BaseModel, BaseModel> ConstructEditFunction()
        {
            return (x) =>
            {
                ViewContext.AddErrors(_notImplementedActionMessage);
                return x;
            };
        }

        protected override Func<BaseModel, bool> ConstructDeleteFunction()
        {
            return (x) =>
            {
                ViewContext.AddErrors(_notImplementedActionMessage);
                return false;
            };
        }
    }
}
