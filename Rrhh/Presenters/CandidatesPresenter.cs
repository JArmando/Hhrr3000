using Rrhh.Models;
using System.Collections.Generic;
using System.Linq;

namespace Rrhh.Presenters
{
    public abstract class PresentedModel
    {
        protected BaseModel Model { get; set; }
        public string State => Model.IsActive ? "Active" : "Deactivated";

        protected PresentedModel(BaseModel model)
        {
            Model = model;
        }

        public BaseModel UnWrappModel()
        {
            return Model;
        }
    }

    public abstract class ModelsPresenter<T> where T: BaseModel
    {
        internal IEnumerable<T> _models;
        internal IEnumerable<PresentedModel> _presentedModels;
        public IEnumerable<PresentedModel> Models => PresentModels();
        protected abstract IEnumerable<PresentedModel> PresentModels();

        protected ModelsPresenter(IEnumerable<T> models)
        {
            _models = models;
        }
    }

    public class CandidatesPresenter : ModelsPresenter<Candidate>
    {
        public CandidatesPresenter(IEnumerable<Candidate> candidates) : base(candidates)
        {
        }
        protected override IEnumerable<PresentedModel> PresentModels()
        {
            _presentedModels = _presentedModels ?? _models.Select(x => new PresentedCandidate(x));
            return _presentedModels;
        }
    }
    public class PresentedCandidate : PresentedModel
    {
        public PresentedCandidate(BaseModel model) : base(model){}

        private Candidate Candidate => Model as Candidate;
        public string Name => Candidate.FirstName +" "+ Candidate.LastName;
        public string PhoneNumber => Candidate.Phone;
        public string ApplyingForJob => Candidate.JobOfferAspiration.Job.Name;
        public string SocialId => Candidate.GovernmentIssuedId;
    }
}
