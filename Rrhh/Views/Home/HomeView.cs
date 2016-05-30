using System;
using System.Windows.Forms;
using Rrhh.Controllers;
using Rrhh.Views.Candidates;

namespace Rrhh.Views.Home
{
    public partial class HomeView : Form
    {
        private HomePresenter Presenter { get; }
        private HomeController Controller { get; }

        public HomeView(HomeController controller = null)
        {
            InitializeComponent();
            Controller = controller?? new HomeController();

            Presenter = Controller.Presenter;
        }

        private void AddNewCandidateBtn_Click(object sender, EventArgs e)
        {
            var dialog = new NewCandidateView(new CandidatesController(Controller.Context));
            DisplayInBox(dialog);
        }

        private void ListCandidatesBtn_Click(object sender, EventArgs e)
        {
            var dialog = new NewCandidateView(new CandidatesController(Controller.Context));
        }

        private void DisplayInBox(Form control)
        {
            control.TopLevel = false;
            control.FormBorderStyle = FormBorderStyle.None;
            TheBox.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            control.Show();
        }
    }
}
