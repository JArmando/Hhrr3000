using System;
using System.Linq;
using System.Windows.Forms;
using Rrhh.Controllers;
using Rrhh.Models;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Candidates
{
    public partial class ListCandidates : BaseView
    {
        private CandidatesController Controller { get; }
        public ListCandidates(ViewContext viewcontext, CandidatesController controller) : base(viewcontext)
        {
            InitializeComponent();
            Controller = controller;
            LoadCandidates();
        }

        public void LoadCandidates()
        {
            CandidatesGrid.DataSource = Controller.ListCandidates().ToList();
        }

        private void HireBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in CandidatesGrid.SelectedRows)
            {
                Controller.Hire(selectedRow.DataBoundItem as Candidate);
            }
            //notify that the candidates were hired and get out of this view
        }
    }
}
