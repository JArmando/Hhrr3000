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
using Rrhh.Models;

namespace Rrhh.Views.Candidates
{
    public partial class ListCandidates : Form
    {
        private CandidatesController Controller { get; }
        public ListCandidates(CandidatesController controller)
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
            Controller.SaveChanges();
            //notify that the candidates were hired and get out of this view
        }
    }
}
