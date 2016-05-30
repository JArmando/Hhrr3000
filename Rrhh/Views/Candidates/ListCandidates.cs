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

namespace Rrhh.Views.Candidates
{
    public partial class ListCandidates : Form
    {
        private CandidatesController Controller { get; }
        public ListCandidates(CandidatesController controller)
        {
            InitializeComponent();
            LoadCandidates();
            Controller = controller;
        }

        public void LoadCandidates()
        {
            CandidatesGrid.DataSource = Controller.ListCandidates();
        }
    }
}
