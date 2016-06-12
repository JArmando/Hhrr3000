using System;
using System.Windows.Forms;
using Rrhh.Controllers;
using Rrhh.Migrations;
using Rrhh.Presenters;
using Rrhh.Views.Candidates;
using Rrhh.Views.Departments;
using Rrhh.Views.Employees;
using Rrhh.Views.JobOffers;
using Rrhh.Views.Jobs;
using Rrhh.Views.Languages;
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
            //var view = new ListCandidates(ViewContext, new CandidatesController(DataContext));
            var controller = new CandidatesController(Context);
            var presenter = new CandidatesPresenter(controller.List());

            var crudMethods = new CrudCandidatesViews(Context, ViewContext);
            var dataSource = new BindingSource { DataSource = presenter.Models };
            var view = new CrudModels(ViewContext, dataSource, crudMethods, x => controller.Filter(x));
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
            var presenter = new EmployeesPresenter(controller.List());
            var crudMethods = new CrudEmployeesViews(Context, ViewContext);
            var dataSource = new BindingSource { DataSource = presenter.Employees};
            
            var view = new CrudModels(ViewContext, dataSource, crudMethods, x => controller.Filter(x));
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

        private void createJobOfferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var controller = new JobOffersController(Context);
            var crudMethods = new JobOffersCrudViews(Context, ViewContext);
            var dataSource = new BindingSource { DataSource = controller.List() };
            var view = new CrudModels(ViewContext, dataSource, crudMethods, x => controller.Filter(x));
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
            //var view = new EditEmployee(ViewContext, new EmployeesController(DataContext) );
            //NavigateTo(view);
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var controller = new JobsController(Context);
            var presenter = new JobsPresenter(controller.List());
            var crudMethods = new JobsCrudViews(Context, ViewContext);
            var dataSource = new BindingSource { DataSource = presenter.Models };
            var view = new CrudModels(ViewContext, dataSource, crudMethods, x => controller.Filter(x));
            NavigateTo(view);
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var controller = new DepartmentsController(Context);
            var presenter = new DepartmentsPresenter(controller.List());
            var crudMethods = new DepartmentsCrudViews(Context, ViewContext);
            var datasource = new BindingSource {DataSource = presenter.Models};
            var view = new CrudModels(ViewContext, datasource, crudMethods, x => controller.Filter(x));
            NavigateTo(view);
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = new NewLanguage();
            view.ShowDialog();
            Context.Languages.Add(view.Model);
            Context.SaveChanges();
        }
    }
}
