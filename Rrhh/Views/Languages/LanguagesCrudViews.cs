using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Views.Candidates;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Languages
{
    public class LanguagesCrudViews : CrudViews
    {
        public LanguagesCrudViews(RrhhContext dataContext, ViewContext viewContext) : base(dataContext, viewContext)
        {
        }

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
                var view = new NewLanguage(ViewContext);
                view.ShowDialog();
                return view.Model;
            };
        }
    }
}
