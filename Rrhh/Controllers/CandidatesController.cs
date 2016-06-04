using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Views;

namespace Rrhh.Controllers
{
    public class CandidatesController : BaseController
    {
        public CandidatesController(RrhhContext context) : base(context, context.Candidates)
        {
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

        public bool Hire(Candidate candidate)
        {
            HireCandidate.Call(Context, candidate);
            return true;
        }

        public IEnumerable<Candidate> ListCandidates()
        {
            return Context.Candidates;
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
            if (employee.IsValid()) Context.SaveChanges();
            return employee;
        }
    }
}
