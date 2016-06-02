using System;
using System.Linq;
using System.Windows.Forms;
using Rrhh.Controllers;
using Rrhh.Models;
using Rrhh.Views.Home;
using Rrhh.Views.Resumes;

namespace Rrhh.Views
{
    public partial class NewCandidateView : BaseView
    {
        public Candidate Candidate { get; set; }
        private Resume Resume { get; set; }
        private CandidatesController Controller { get; }
        
        public NewCandidateView(ViewContext viewContext, CandidatesController controller)
        {
            InitializeComponent();
            Controller = controller;
            AddCandidateBtn.Enabled = false;
            ViewContext = viewContext;
        }

        private void AddCandidateBtn_Click(object sender, EventArgs e)
        {
            var firstName = FirstNameTxtBox.Text;
            var lastName = LastNameTxtBox.Text;
            var phone = PhoneNumberTxtBox.Text;
            var email = EmailTxtBox.Text;
            var governmentIssuedId = SocialIdTxtBox.Text;
            var aspiringSalary = decimal.Parse(aspiringSalaryTxtBox.Text);
            var candidate = Controller.New(firstName, lastName, governmentIssuedId, email, phone, aspiringSalary, Resume);
            ViewContext.Errors.AddRange(candidate.Errors.Select(x => x.ErrorMessage));
        }

        private void AttachResumeBtn_Click(object sender, EventArgs e)
        {
            var dialog = new NewResume(Resume);
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
    }
}
