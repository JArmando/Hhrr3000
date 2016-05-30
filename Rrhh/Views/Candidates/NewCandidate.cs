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
using Rrhh.Views.Resumes;

namespace Rrhh.Views
{
    public partial class NewCandidate : Form
    {
        public Candidate Candidate { get; set; }
        private Resume Resume { get; set; }
        
        public NewCandidate()
        {
            InitializeComponent();
        }

        private void AddCandidateBtn_Click(object sender, EventArgs e)
        {
            var controller = new CandidatesController();
            var firstName = FirstNameTxtBox.Text;
            var lastName = LastNameTxtBox.Text;
            var phone = PhoneNumberTxtBox.Text;
            var email = EmailTxtBox.Text;
            controller.AddCandidate(firstName, lastName, email, phone, Resume);
        }

        private void AttachResumeBtn_Click(object sender, EventArgs e)
        {
            var dialog = new NewResume();
            dialog.ShowDialog();
            Resume = dialog.Resume;
        }
    }
}
