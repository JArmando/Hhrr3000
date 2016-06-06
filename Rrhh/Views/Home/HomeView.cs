using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Rrhh.Controllers;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Views.Candidates;
using Rrhh.Views.Departments;
using Rrhh.Views.Employees;
using Rrhh.Views.JobOffers;
using Rrhh.Views.Jobs;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Home
{
    public partial class HomeView : Form
    {
        
        private HomeController Controller { get; }
        private RrhhContext Context => Controller.Context;
        private ViewContext ViewContext { get; }
        private HomePresenter Presenter => Controller.Presenter;

        public HomeView(HomeController controller, ViewContext viewContext)
        {
            InitializeComponent();
            Controller = controller;
            ViewContext = viewContext;
            ViewContext.Notifier = x =>
            {
                InfoBox.Text = string.Join("\n", x);
            }   ;
        }

        private void AddNewCandidateBtn_Click(object sender, EventArgs e)
        {
            var view = new NewCandidateView(ViewContext, new CandidatesController(Context));
            NavigateTo(view);
        }

        private void ListCandidatesBtn_Click(object sender, EventArgs e)
        {
            //var view = new ListCandidates(ViewContext, new CandidatesController(Context));
            var controller = new CandidatesController(Context);

            var crudMethods = new CrudCandidatesMethods(Context, ViewContext);
            var dataSource = new BindingSource { DataSource = controller.Presenter.Candidates };
            var view = new CrudModels(ViewContext, dataSource, crudMethods);
            NavigateTo(view);
        }

        private void EmployeeNewToolStrip_Click(object sender, EventArgs e)
        {
            var view = new NewEmployeeView(ViewContext, new EmployeesController(Context));
            NavigateTo(view);
        }
        private void EmployeeListToolStrip_Click(object sender, EventArgs e)
        {
            var controller = new EmployeesController(Context);
            var crudMethods = new CrudEmployeesMethods(Context, ViewContext);
            var dataSource = new BindingSource { DataSource = controller.ListEmployees().ToList()};
            
            var view = new CrudModels(ViewContext, dataSource, crudMethods);
            NavigateTo(view);
        }

        private void NavigateTo(Form view)
        {
            view.TopLevel = false;
            view.FormBorderStyle = FormBorderStyle.None;
            TheBox.Controls.Clear();
            TheBox.Controls.Add(view);
            view.Dock = DockStyle.Bottom;
            view.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoBox.Text = string.Join("\n", ViewContext.Errors);
        }

        private void createJobOfferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = new NewJobOffer(ViewContext, new JobOffersController(Context));
            NavigateTo(view);
        }

        private void createJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = new NewJob(ViewContext, new JobsController(Context));
            NavigateTo(view);
        }

        private void createDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = new NewDepartment(ViewContext, new DepartmentsController(Context));
            NavigateTo(view);
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var view = new EditEmployee(ViewContext, new EmployeesController(Context) );
            //NavigateTo(view);
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var controller = new JobsController(Context);

            var crudMethods = new JobsCrudMethods(Context, ViewContext);
            var dataSource = new BindingSource { DataSource = controller.List() };
            var view = new CrudModels(ViewContext, dataSource, crudMethods);
            NavigateTo(view);
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var controller = new DepartmentsController(Context);
            var crudMethods = new DepartmentsCrudMethods(Context, ViewContext);
            var datasource = new BindingSource {DataSource = controller.List()};
            var view = new CrudModels(ViewContext, datasource, crudMethods);
            NavigateTo(view);
        }
    }
}
