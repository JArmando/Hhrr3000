using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rrhh.Controllers;

namespace Rrhh.Views.Departments
{
    public partial class NewDepartment : BaseView
    {
        private readonly DepartmentsController _controller;
        private readonly ViewContext _viewContext;
        public NewDepartment(DepartmentsController controller, ViewContext viewContext)
        {
            InitializeComponent();
            _controller = controller;
            _viewContext = viewContext;
        }

        private void CreateDepartmentBtn_Click(object sender, EventArgs e)
        {
            var name = NameTxtBox.Text;
            var description = DescriptionTxtBox.Text;
            var department = _controller.Create(name, description);
            _viewContext.AddErrors(department);
        }
    }
}
