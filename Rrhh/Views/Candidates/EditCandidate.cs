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
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Candidates
{
    public partial class EditCandidate : BaseView
    {
        private RrhhContext Context;
        private Candidate Candidate;
        private CandidatesController Controller;
        public EditCandidate(RrhhContext context, ViewContext viewContext, Candidate candidate, CandidatesController controller) : base(viewContext)
        {
            InitializeComponent();
            Context = context;
            Candidate = candidate;
            Controller = controller;
            LoadData();
        }

        private void UpdateCandidateButton_Click(object sender, EventArgs e)
        {
            Candidate.FirstName = FirstNameTxtBox.Text;
            Candidate.LastName = LastNameTxtBox.Text;
            Candidate.Phone = PhoneNumberTxtBox.Text;
            Candidate.Email = EmailTxtBox.Text;
            Candidate.GovernmentIssuedId= SocialIdTxtBox.Text;
            Candidate.AspiringSalary = decimal.Parse(aspiringSalaryTxtBox.Text);
            var candidate = Controller.Update(Candidate);
            ViewContext.AddErrors(candidate);
            Close();
        }

        private void LoadData()
        {
            FirstNameTxtBox.Text = Candidate.FirstName;
            LastNameTxtBox.Text = Candidate.LastName;
            PhoneNumberTxtBox.Text = Candidate.Phone;
            EmailTxtBox.Text = Candidate.Email;
            SocialIdTxtBox.Text = Candidate.GovernmentIssuedId;
            aspiringSalaryTxtBox.Text = Candidate.AspiringSalary.ToString();
        }
    }
}
