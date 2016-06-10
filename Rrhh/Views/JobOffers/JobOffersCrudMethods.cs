using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Rrhh.Controllers;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Views.Candidates;
using Rrhh.Views.Shared;

namespace Rrhh.Views.JobOffers
{
    public class JobOffersCrudViews : CrudViews
    {
        public JobOffersCrudViews(RrhhContext dataContext, ViewContext viewContext) : base(dataContext, viewContext){}

        protected override Func<BaseModel, BaseModel> ConstructEditFunction()
        {
            return FunctionNotImplemented();
        }

        protected override Func<BaseModel, bool> ConstructDeleteFunction()
        {
            throw new NotImplementedException();
        }

        protected override Func<BaseModel, BaseModel> ConstructEspecialFunction()
        {
            return FunctionNotImplemented();
        }

        protected override Func<BaseModel> ConstructCreateFunction()
        {
            return () =>
            {
                var view = new NewJobOffer(ViewContext, new JobOffersController(DataContext));
                view.ShowDialog();
                return view.JobOffer;
            };
        }
    }
}
