using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Views;
using Rrhh.Presenters;

namespace Rrhh.Controllers
{
    public class CandidatesController : BaseController
    {
        public CandidatesPresenter Presenter { get; }

        public CandidatesController(RrhhContext context) : base(context, context.Candidates)
        {
            Presenter = new CandidatesPresenter(context.Candidates.Active());
        }

        public Candidate New(string firstName, string lastName, string governmentIssuedId, string email,
            string phoneNumber, decimal aspiringSalary)
        {
            return new Candidate
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Phone = phoneNumber,
                GovernmentIssuedId = governmentIssuedId,
            };
        }

        public Candidate New(string firstName, string lastName, string governmentIssuedId, string email,
            string phoneNumber, decimal aspiringSalary, Resume resume, JobOffer jobOffer)
        {
            var newCandidate = New(firstName, lastName, governmentIssuedId, email, phoneNumber, aspiringSalary);
            newCandidate.JobOfferAspiration = jobOffer;
            newCandidate.Resume = resume;
            return newCandidate;
        }

        public Candidate Create(string firstName, string lastName, string governmentIssuedId, string email,
            string phoneNumber, decimal aspiringSalary, Resume resume, JobOffer jobOffer)
        {
            var newCandidate = New(firstName, lastName, governmentIssuedId, email, phoneNumber, aspiringSalary, resume,
                jobOffer);
            if (newCandidate.IsValid()) DoCreate(newCandidate);
            // Need to do this here because candidates have a special way of validating
            return newCandidate;
        }

        public Employee Hire(Candidate candidate)
        {
            var employee = HireCandidate.Call(Context, candidate);
            return employee;
        }

        public IEnumerable<PresentedCandidate> Filter(string searchParam)
        {
            var result = Context.Candidates.Active().Where(x =>
              x.Resume.Competences.Any(c => c.Description.Contains(searchParam)) ||
              x.JobOfferAspiration.Job.Name.Contains(searchParam) ||
              x.JobOfferAspiration.Job.Description.Contains(searchParam)
            );
            return new CandidatesPresenter(result).Candidates;
        }
    }
    public class HireCandidate
    {
        private RrhhContext Context { get; }

        public HireCandidate(RrhhContext context)
        {
            Context = context;
        }

        public static Employee Call(RrhhContext Context, Candidate candidate)
        {
            return new HireCandidate(Context).Call(candidate);
        }

        private Employee Call(Candidate candidate)
        {
            var employee = (Employee)candidate;
            employee.HireDate = DateTime.Now;
            candidate.IsActive = false;
            if (employee.IsValid())
            {
                Context.Employees.Add(employee);
                Context.SaveChanges();
            }
            return employee;
        }
    }
}
