using System;
using System.Windows.Forms;
using Rrhh.Controllers;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Candidates
{
    public abstract class CrudMethods
    {
        internal readonly string NotImplementedActionMessage = "This action is not yet implemented";
        public Func<BaseModel> Create => ConstructCreateFunction();
        public Func<BaseModel, BaseModel> Edit => ConstructEditFunction();
        public Func<BaseModel, bool> Delete => ConstructDeleteFunction();
        protected RrhhContext Context { get; set; }
        protected ViewContext ViewContext { get; set; }
        protected abstract Func<BaseModel, BaseModel> ConstructEditFunction();
        protected abstract Func<BaseModel, bool> ConstructDeleteFunction();

        protected abstract Func<BaseModel> ConstructCreateFunction();

        internal bool YouAreNotSureYouWantToDeleteThis()
        {
            var view = MessageBox.Show(null, "Are you sure you want to delete this?", "WARNING", MessageBoxButtons.YesNo);
            return view != DialogResult.Yes;   
        }
    }

    public class CrudCandidatesMethods : CrudMethods
    {

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
                var view = new EditCandidate(Context, ViewContext, x as Candidate, new CandidatesController(Context));
                view.ShowDialog();
                ViewContext.AddErrors(x);
                return x;
            };
        }

        protected override Func<BaseModel, bool> ConstructDeleteFunction()
        {
            return (x) =>
            {
                if (YouAreNotSureYouWantToDeleteThis()) return false;
                var candidate = x as Candidate;
                var result = CandidatesController.Delete(Context, candidate);
                if (candidate != null) ViewContext.AddErrors($"Candidate {candidate.FirstName} deleted");
                return result;
            };
        }
    }
}
