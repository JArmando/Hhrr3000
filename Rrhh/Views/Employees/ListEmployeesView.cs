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

namespace Rrhh.Views.Employees
{
    public partial class ListEmployeesView : Form
    {
        private EmployeesController Controller { get; }

        public ListEmployeesView(EmployeesController controller)
        {
            InitializeComponent();
            Controller = controller;
            LoadData();
        }

        private void LoadData()
        {
            var context = Controller.Context;
            var employees = context.Employees;
            EmployeeList.DataSource = employees.ToList();
        }

    }
}
