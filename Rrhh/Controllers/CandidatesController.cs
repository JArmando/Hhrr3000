using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rrhh.Migrations;
using Rrhh.Models;

namespace Rrhh.Controllers
{
    public class CandidatesController
    {
        public RrhhContext Context { get; }

        public CandidatesController(RrhhContext context)
        {
            Context = context;
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
            string phoneNumber, decimal aspiringSalary, Resume resume, JobOffer jobOffer = null)
        {
            var newCandidate = New(firstName, lastName, governmentIssuedId, email, phoneNumber, aspiringSalary);
            newCandidate.JobOfferAspiration = jobOffer;
            newCandidate.Resume = resume;
            return Create(newCandidate);
        }

        public Candidate Create(Candidate candidate)
        {
            try
            {
                if (candidate.IsValid()) Context.Candidates.Add(candidate);
                Context.SaveChanges();
            }
            catch (Exception e)
            {
                // Need to log or something
                throw;
            }
            return candidate;
        }

        public bool Hire(Candidate candidate)
        {
            HireCandidate.Call(Context, candidate);
            return true;
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
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
            return employee;
        }
    }
}
