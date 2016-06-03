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
using Rrhh.Views.Shared;

namespace Rrhh.Views.JobOffers
{
    public partial class NewJobOffer : Form
    {
        private JobOffersController Controller;
        private Job Job;
        public NewJobOffer(JobOffersController controller)
        {
            InitializeComponent();
            Controller = controller;
            LoadData();
        }

        private void LoadData()
        {
            RiskLevelsCmbBox.DataSource = NewJobOfferPresenter.RiskLevels;
        }



        private void PickJobBtn_Click(object sender, EventArgs e)
        {
            var jobList = Controller.Context.Jobs.ToList();
            var dataSource = new BindingSource { DataSource = jobList};
            var dialog =  new RowSelector(dataSource);
            dialog.ShowDialog();
            Job = dialog.SelectedItem as Job;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            var maxSalary = decimal.Parse(MaxSalaryTxtBox.Text);
            var minSalary = decimal.Parse(MinSalaryTxtBox.Text);
            var riskLevel = RiskLevelsCmbBox.SelectedText;
            Controller.New(Job, maxSalary, minSalary, riskLevel);
        }
    }

    public class NewJobOfferPresenter
    {
        public static string[] RiskLevels = {"High", "Medium", "Low"};
    }
}
