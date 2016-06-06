using System;
using System.Linq;
using System.Windows.Forms;
using Rrhh.Controllers;
using Rrhh.Models;
using Rrhh.Views.Shared;
using System.Collections.Generic;
using Rrhh.Presenters;

namespace Rrhh.Views.Candidates
{
    public partial class ListCandidates : BaseView
    {
        private CandidatesController Controller { get; }
        private CandidatesPresenter Presenter;
        public ListCandidates(ViewContext viewcontext, CandidatesController controller) : base(viewcontext)
        {
            InitializeComponent();
            Controller = controller;
            Presenter = Controller.Presenter;
            LoadCandidates();
        }

        public void LoadCandidates()
        {
            CandidatesGrid.DataSource = new BindingSource { DataSource = Presenter.Candidates };
        }
        
        private void HireBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in CandidatesGrid.SelectedRows)
            {
                var employee = Controller.Hire(selectedRow.DataBoundItem as Candidate);
                ViewContext.AddErrors(employee);
            }
            //notify that the candidates were hired and get out of this view
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            var result = Controller.Filter(OmniSearchBox.Text);
            CandidatesGrid.DataSource = result.ToList();
        }
    }
}
