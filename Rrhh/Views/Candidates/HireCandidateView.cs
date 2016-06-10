using System;
using Rrhh.Controllers;
using Rrhh.Models;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Candidates
{
    public partial class HireCandidateView : BaseView
    {
        private CandidatesController Controller;
        public Candidate Candidate;
        public Employee Employee;
        public HireCandidateView(ViewContext viewContext, CandidatesController controller, Candidate candidate): base(viewContext)
        {
            InitializeComponent();
            Controller = controller;
            Candidate = candidate;
            EmployeeNameLbl.Text = $"{Candidate.FirstName} {Candidate.LastName}";
        }

        private void CompleteHiringBtn_Click(object sender, EventArgs e)
        {
            var startingDate = startsOn.Value;
            Employee = Controller.Hire(Candidate, startingDate);
            Close();
        }
    }
}
