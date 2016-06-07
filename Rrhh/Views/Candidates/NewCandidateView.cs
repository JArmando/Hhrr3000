using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using Rrhh.Controllers;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Views.Home;
using Rrhh.Views.Resumes;
using Rrhh.Views.Shared;

namespace Rrhh.Views
{
    public partial class NewCandidateView : BaseView
    {
        public Candidate Model { get; set; }
        private Resume Resume {get;set;}
        private JobOffer JobOffer { get; set; }
        private CandidatesController Controller { get; }
        private RrhhContext Context => Controller.Context;
        
        public NewCandidateView(ViewContext viewContext, CandidatesController controller) : base(viewContext)
        {
            InitializeComponent();
            Controller = controller;
            AddCandidateBtn.Enabled = false;
        }

        private void AddCandidateBtn_Click(object sender, EventArgs e)
        {
            var firstName = FirstNameTxtBox.Text;
            var lastName = LastNameTxtBox.Text;
            var phone = PhoneNumberTxtBox.Text;
            var email = EmailTxtBox.Text;
            var governmentIssuedId = SocialIdTxtBox.Text;
            var aspiringSalary = decimal.Parse(aspiringSalaryTxtBox.Text);
            var candidate = Controller.Create(firstName, lastName, governmentIssuedId, email, phone, aspiringSalary, Resume, JobOffer);
            ViewContext.AddErrors(candidate);
        }

        private void AttachResumeBtn_Click(object sender, EventArgs e)
        {
            var dialog = new NewResume(Context, ViewContext, Resume);
            dialog.ShowDialog();
            Resume = dialog.Resume;
            if (ResumeIsAttached()) EnableBtn(AddCandidateBtn);
        }

        private bool ResumeIsAttached()
        {
            return Resume != null;
        }

        private static void EnableBtn(Control button)
        {
            button.Enabled = true;
        }

        private void selectJobOfferBtn_Click(object sender, EventArgs e)
        {
            var bindingSource = new BindingSource { DataSource = Context.JobOffers.ToList()};
            // please use the controller's list method
            var dialog = new RowSelector(bindingSource);
            dialog.ShowDialog();
            JobOffer = dialog.SelectedItem as JobOffer;
        }
    }
}
