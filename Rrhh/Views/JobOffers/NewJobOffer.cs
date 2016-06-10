using System;
using System.Linq;
using System.Windows.Forms;
using Rrhh.Controllers;
using Rrhh.Models;
using Rrhh.Views.Jobs;
using Rrhh.Views.Shared;

namespace Rrhh.Views.JobOffers
{
    public partial class NewJobOffer : BaseView
    {
        private readonly JobOffersController _controller;
        private Job Job;
        public JobOffer JobOffer;
        public NewJobOffer(ViewContext viewContext, JobOffersController controller) : base(viewContext)
        {
            InitializeComponent();
            _controller = controller;
            LoadData();
        }

        private void LoadData()
        {
            RiskLevelsCmbBox.DataSource = NewJobOfferPresenter.RiskLevels;
        }

        private void PickJobBtn_Click(object sender, EventArgs e)
        {
            var jobList = _controller.Context.Jobs.ToList();
            var dataSource = new BindingSource { DataSource = jobList};
            var crud = new JobsCrudViews(_controller.Context, ViewContext);
            var dialog =  new RowSelector(dataSource, crud);
            dialog.ShowDialog();
            Job = dialog.SelectedItem as Job;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            var maxSalary = decimal.Parse(MaxSalaryTxtBox.Text);
            var minSalary = decimal.Parse(MinSalaryTxtBox.Text);
            var riskLevel = RiskLevelsCmbBox.SelectedItem.ToString();
            JobOffer = _controller.Create(Job, maxSalary, minSalary, riskLevel);
            ViewContext.AddErrors(JobOffer);
        }
    }

    public class NewJobOfferPresenter
    {
        public static string[] RiskLevels = {"High", "Medium", "Low"};
    }
}
