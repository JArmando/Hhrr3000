﻿using System;
using System.Windows.Forms;
using Rrhh.Controllers;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Views.Candidates;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Departments
{
    public class DepartmentsCrudViews : CrudViews
    {
        public DepartmentsCrudViews(RrhhContext dataContext, ViewContext viewContext) : base(dataContext, viewContext){}

        protected override Func<BaseModel, BaseModel> ConstructEditFunction()
        {
            throw new NotImplementedException();
        }

        protected override Func<BaseModel, bool> ConstructDeleteFunction()
        {
            return x =>
            {
                var view = MessageBox.Show(null, "Are you sure you want to delete this?", "WARNING", MessageBoxButtons.YesNo);
                var result = false;

                if (view != DialogResult.Yes) return result;

                var department = x as Department;
                result = DepartmentsController.Delete(DataContext, department);
                if (department != null) ViewContext.AddErrors($"Department {department.Name} deleted");
                return result;
            };
        }

        protected override Func<BaseModel, BaseModel> ConstructEspecialFunction()
        {
            return null;
        }

        protected override Func<BaseModel> ConstructCreateFunction()
        {
            return () =>
            {
                var view = new NewDepartment(ViewContext, new DepartmentsController(DataContext));
                view.ShowDialog();
                return view.Department;
            };
        }
    }
}
