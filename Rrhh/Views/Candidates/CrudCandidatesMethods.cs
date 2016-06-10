using System;
using System.Windows.Forms;
using Rrhh.Controllers;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Candidates
{
    public abstract class CrudViews
    {
        internal readonly string NotImplementedActionMessage = "This action is not yet implemented";

        internal CrudViews(RrhhContext dataContext, ViewContext viewContext)
        {
            DataContext = dataContext;
            ViewContext = viewContext;
        }

        public string EspecialActionName;
        public Func<BaseModel> Create => ConstructCreateFunction();
        public Func<BaseModel, BaseModel> Edit => ConstructEditFunction();
        public Func<BaseModel, bool> Delete => ConstructDeleteFunction();
        public Func<BaseModel, BaseModel> EspecialAction => ConstructEspecialFunction();
        protected RrhhContext DataContext { get; set; }
        protected ViewContext ViewContext { get; set; }
        protected abstract Func<BaseModel, BaseModel> ConstructEditFunction();
        protected abstract Func<BaseModel, bool> ConstructDeleteFunction();
        protected abstract Func<BaseModel, BaseModel> ConstructEspecialFunction();

        protected abstract Func<BaseModel> ConstructCreateFunction();

        internal bool YouAreNotSureYouWantToDeleteThis()
        {
            var view = MessageBox.Show(null, "Are you sure you want to delete this?", "WARNING", MessageBoxButtons.YesNo);
            return view != DialogResult.Yes;   
        }

        internal Func<BaseModel, BaseModel> FunctionNotImplemented()
        {
            return (x) =>
            {
                ViewContext.AddErrors(NotImplementedActionMessage);
                return x;
            };
        }
    }

    public class CrudCandidatesViews : CrudViews
    {

        public CrudCandidatesViews(RrhhContext dataContext, ViewContext viewContext) : base(dataContext, viewContext)
        {
            EspecialActionName = "Hire";
        }

        protected override Func<BaseModel, BaseModel> ConstructEspecialFunction()
        {
            return HireFunction();
        }

        private Func<BaseModel, BaseModel> HireFunction()
        {
            return (x) =>
            {
                var controller = new CandidatesController(DataContext);
                var view = new HireCandidateView(ViewContext, controller, x as Candidate);
                view.ShowDialog();
                return view.Employee;
            };
        }

        protected override Func<BaseModel> ConstructCreateFunction()
        {
            return () =>
            {
                var view = new NewCandidateView(ViewContext, new CandidatesController(DataContext));
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
                var view = new EditCandidate(DataContext, ViewContext, x as Candidate, new CandidatesController(DataContext));
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
                var result = CandidatesController.Delete(DataContext, candidate);
                if (candidate != null) ViewContext.AddErrors($"Candidate {candidate.FirstName} deleted");
                return result;
            };
        }
    }
}
