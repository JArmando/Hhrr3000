﻿using System;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Views.Candidates;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Competences
{
    public class CompetencesCrudViews : CrudViews
    {
        public CompetencesCrudViews(RrhhContext dataContext, ViewContext viewContext) : base(dataContext, viewContext){}

        protected override Func<BaseModel, BaseModel> ConstructEditFunction()
        {
            return FunctionNotImplemented();
        }

        protected override Func<BaseModel, bool> ConstructDeleteFunction()
        {
            return null;
        }

        protected override Func<BaseModel, BaseModel> ConstructEspecialFunction()
        {
            return FunctionNotImplemented();
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
