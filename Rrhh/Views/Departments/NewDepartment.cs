﻿using System;
using Rrhh.Controllers;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Departments
{
    public partial class NewDepartment : BaseView
    {
        private readonly DepartmentsController _controller;

        public NewDepartment(ViewContext viewContext, DepartmentsController controller) : base(viewContext)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void CreateDepartmentBtn_Click(object sender, EventArgs e)
        {
            var name = NameTxtBox.Text;
            var description = DescriptionTxtBox.Text;
            var department = _controller.Create(name, description);
            ViewContext.AddErrors(department);
        }
    }
}
