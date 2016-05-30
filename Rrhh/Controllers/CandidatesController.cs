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
        private RrhhContext Context { get; }

        public CandidatesController()
        {
            Context = new RrhhContext();
        }

        public bool AddCandidate(string firstName, string lastName, string email, string phoneNumber, Resume resume)
        {
            Context.Candidates.Add(new Candidate
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Phone = phoneNumber,
                Resume = resume
            });
            Context.SaveChanges();
            return true;
        }

        public IEnumerable<Candidate> ListCandidates()
        {
            return Context.Candidates.ToList();
        }
    }
}
