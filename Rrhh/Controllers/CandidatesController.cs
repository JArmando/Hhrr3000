using System;
using System.Collections.Generic;
using System.Linq;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Presenters;

namespace Rrhh.Controllers
{
    public class CandidatesController : BaseController<Candidate>
    {
        public CandidatesPresenter Presenter { get; }

        public CandidatesController(RrhhContext context) : base(context, context.Candidates)
        {
            Presenter = new CandidatesPresenter(Dbset.Active());
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

        public static bool Delete(RrhhContext dataContext, Candidate candidate)
        {
            return new CandidatesController(dataContext).Delete(candidate);
        }

        public bool Delete(Candidate candidate)
        {
            return DoDelete(candidate);
        }

        public Candidate Update(Candidate candidate)
        {
            // Todo: implement
            return candidate;
        }

        public IEnumerable<Candidate> List()
        {
            return Dbset.Active();
        }

        public Employee Hire(Candidate candidate, DateTime startsOn)
        {
            var employee = HireCandidate.Call(Context, candidate, startsOn);
            return employee;
        }

        public static Employee Hire(RrhhContext dataContext, Candidate candidate, DateTime startsOn)
        {
            return new CandidatesController(dataContext).Hire(candidate, startsOn);
        }

        public IEnumerable<PresentedCandidate> Filter(string s)
        {
            var result = Context.Candidates.Active().Where(x =>
                x.FirstName.Contains(s) ||
                x.LastName.Contains(s) ||
                x.Phone.Contains(s) ||
                x.GovernmentIssuedId.Contains(s) ||
                x.Resume.Competences.Any(c => c.Description.Contains(s)) ||
                x.JobOfferAspiration.Job.Name.Contains(s) ||
                x.JobOfferAspiration.Job.Description.Contains(s)
            );
            return new CandidatesPresenter(result).Models as IEnumerable<PresentedCandidate>;
        }
    }
    public class HireCandidate
    {
        private RrhhContext Context { get; }

        public HireCandidate(RrhhContext context)
        {
            Context = context;
        }

        public static Employee Call(RrhhContext Context, Candidate candidate, DateTime startsOn)
        {
            return new HireCandidate(Context).Call(candidate, startsOn);
        }

        private Employee Call(Candidate candidate, DateTime startsOn)
        {
            var employee = (Employee)candidate;
            employee.HireDate = startsOn;
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
