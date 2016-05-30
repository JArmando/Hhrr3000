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
        public ListCandidates()
        {
            InitializeComponent();
            LoadCandidates();
        }

        public void LoadCandidates()
        {
            var controller = new CandidatesController();
            CandidatesGrid.DataSource = controller.ListCandidates();
        }
    }
}
