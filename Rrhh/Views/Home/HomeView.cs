using System;
using System.Windows.Forms;
using Rrhh.Controllers;
using Rrhh.Migrations;
using Rrhh.Views.Candidates;
using Rrhh.Views.Employees;

namespace Rrhh.Views.Home
{
    public partial class HomeView : Form
    {
        
        private HomeController Controller { get; }
        private RrhhContext Context => Controller.Context;
        private HomePresenter Presenter => Controller.Presenter;

        public HomeView(HomeController controller = null)
        {
            InitializeComponent();
            Controller = controller?? new HomeController();
        }

        private void AddNewCandidateBtn_Click(object sender, EventArgs e)
        {
            var view = new NewCandidateView(new CandidatesController(Context));
            NavigateTo(view);
        }

        private void ListCandidatesBtn_Click(object sender, EventArgs e)
        {
            var view = new ListCandidates(new CandidatesController(Context));
            NavigateTo(view);
        }

        private void EmployeeNewToolStrip_Click(object sender, EventArgs e)
        {
            var view = new NewEmployeeView(new EmployeesController(Context));
            NavigateTo(view);
        }
        private void EmployeeListToolStrip_Click(object sender, EventArgs e)
        {
            var view = new ListEmployeesView(new EmployeesController(Context));
            NavigateTo(view);
        }

        private void NavigateTo(Form view)
        {
            view.TopLevel = false;
            view.FormBorderStyle = FormBorderStyle.None;
            TheBox.Controls.Clear();
            TheBox.Controls.Add(view);
            view.Dock = DockStyle.Top;
            view.Show();
        }


    }
}
