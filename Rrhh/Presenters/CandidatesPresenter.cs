using Rrhh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rrhh.Presenters
{
    public abstract class PresentedModel
    {
        public BaseModel Model { get; set; }
    }

    public class CandidatesPresenter
    {
        private IEnumerable<Candidate> _candidates;
        public IEnumerable<PresentedCandidate> Candidates => PresentCandidates();
        private IEnumerable<PresentedCandidate> _presentedCandidates;
        public CandidatesPresenter(IEnumerable<Candidate> candidates)
        {
            _candidates = candidates;
        }

        private IEnumerable<PresentedCandidate> PresentCandidates() {
            _presentedCandidates = _presentedCandidates ?? _candidates.Select(x => new PresentedCandidate(x));
            return _presentedCandidates;
        }
        
    }
    public class PresentedCandidate : PresentedModel
    {
        public PresentedCandidate(BaseModel model)
        {
            Model = model;
        }

        private Candidate Candidate => Model as Candidate;
        public string Name => Candidate.FirstName +" "+ Candidate.LastName;
        public string PhoneNumber => Candidate.Phone;
        public string ApplyingForJob => Candidate.JobOfferAspiration.Job.Name;
        public string SocialId => Candidate.GovernmentIssuedId;
    }
}
