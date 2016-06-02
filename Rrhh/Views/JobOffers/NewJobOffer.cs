using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rrhh.Views.JobOffers
{
    public partial class NewJobOffer : Form
    {
        public NewJobOffer(JobOfferController controller)
        {
            InitializeComponent();
            Controller = controller;
            LoadData();
        }

        private void LoadData()
        {
            RiskLevelsCmbBox.DataSource = NewJobOfferPresenter.RiskLevels;
        }
    }

    public class NewJobOfferPresenter
    {
        public static string[] RiskLevels = {"High", "Medium", "Low"};
    }
}
