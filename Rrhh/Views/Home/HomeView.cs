using System;
using System.Linq;
using System.Windows.Forms;
using Rrhh.Controllers;
using Rrhh.Migrations;
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
            };
        }

        private void AddNewCandidateBtn_Click(object sender, EventArgs e)
        {
            var view = new NewCandidateView(ViewContext, new CandidatesController(Context));
            NavigateTo(view);
        }

        private void ListCandidatesBtn_Click(object sender, EventArgs e)
        {
            var view = new ListCandidates(ViewContext, new CandidatesController(Context));
            NavigateTo(view);
        }

        private void EmployeeNewToolStrip_Click(object sender, EventArgs e)
        {
            var view = new NewEmployeeView(ViewContext, new EmployeesController(Context));
            NavigateTo(view);
        }
        private void EmployeeListToolStrip_Click(object sender, EventArgs e)
        {
            var view = new ListEmployeesView(ViewContext, new EmployeesController(Context));
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
    }
}
