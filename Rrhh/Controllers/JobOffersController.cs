using System.Collections.Generic;
using System.Linq;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Presenters;

namespace Rrhh.Controllers
{
    public class JobOffersController : BaseController<JobOffer>
    {

        public JobOffersController(RrhhContext context) : base(context, context.JobOffers)
        {
        }

        public JobOffer New(Job job, decimal maxSalary, decimal minSalary, string riskLevel)
        {
            return new JobOffer
            {
                Job = job,
                MaxSalary = maxSalary,
                MinSalary = minSalary,
                RiskLevel = riskLevel
            };
        }

        public JobOffer Create(Job job, decimal maxSalary, decimal minSalary, string riskLevel)
        {
            var newJobOffer = New(job, maxSalary, minSalary, riskLevel);
            DoCreate(newJobOffer);
            return newJobOffer;
        }

        public IEnumerable<JobOffer> List()
        {
            return Context.JobOffers.ToList();
        }

        public IEnumerable<PresentedModel> Filter(string s)
        {
            var result = Dbset.Active().Where(x =>
                          x.Job.Name.Contains(s) ||
                          x.Job.Description.Contains(s)
                        );
            return new JobOffersPresenter(result).Models;
        }
    }

    public class JobOffersPresenter : ModelsPresenter<JobOffer>
    {
        private readonly IEnumerable<JobOffer> _models;

        public JobOffersPresenter(IEnumerable<JobOffer> models) : base(models)
        {}

        protected override IEnumerable<PresentedModel> PresentModels()
        {
            _presentedModels = _presentedModels ?? _models.Select(x => new PresentedJobOffer(x));
            return _presentedModels;
        }
    }

    public class PresentedJobOffer : PresentedModel
    {
        public PresentedJobOffer(BaseModel model) : base(model){}

        private JobOffer JobOffer => Model as JobOffer;
        private Job Job => JobOffer.Job;
        public string Name => Job.Name;
        public string Description => Job.Description;
        public string CreatedAt => JobOffer.CreatedDate.ToString();
    }
}
