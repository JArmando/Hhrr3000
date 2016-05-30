using System;
using System.Windows.Forms;
using Rrhh.Controllers;
using Rrhh.Models;
using Rrhh.Views.Resumes;

namespace Rrhh.Views
{
    public partial class NewCandidateView : Form
    {
        public Candidate Candidate { get; set; }
        private Resume Resume { get; set; }
        private CandidatesController Controller { get; }
        
        public NewCandidateView(CandidatesController controller)
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
            Controller.Create(firstName, lastName, email, phone, Resume);
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
