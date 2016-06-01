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
            newCandidate.JobOfferAspiration = jobOffer ?? new JobOffer();
            newCandidate.Resume = resume ?? new Resume();
            return Create(newCandidate);
        }

        public Candidate Create(Candidate candidate)
        {
            Context.Candidates.Add(candidate);
            Context.SaveChanges();
            return candidate;
        }

        public IEnumerable<Candidate> ListCandidates()
        {
            return Context.Candidates.ToList();
        }
    }
}
