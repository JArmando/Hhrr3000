using Rrhh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rrhh.Presenters
{
    public class CandidatesPresenter
    {
        private IEnumerable<Candidate> _candidates;
        public IEnumerable<PresentedCandidate> Candidates => presentCandidates();
        private IEnumerable<PresentedCandidate> _presentedCandidates;
        public CandidatesPresenter(IEnumerable<Candidate> candidates)
        {
            _candidates = candidates;
        }

        private IEnumerable<PresentedCandidate> presentCandidates() {
            _presentedCandidates = _presentedCandidates ?? _candidates.Select(x => new PresentedCandidate(x));
            return _presentedCandidates;
        }
        
    }
    public class PresentedCandidate
    {
        private Candidate _candidate;
        public PresentedCandidate(Candidate candidate)
        {
            _candidate = candidate;
        }

        public string Name => _candidate.FirstName +" "+ _candidate.LastName;
        public string PhoneNumber => _candidate.Phone;
        public string ApplyingForJob => _candidate.JobOfferAspiration.Job.Name;
        public string SocialId => _candidate.GovernmentIssuedId;
    }
}
