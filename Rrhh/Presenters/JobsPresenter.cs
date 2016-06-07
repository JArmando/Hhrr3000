using System.Collections.Generic;
using System.Linq;
using Rrhh.Models;

namespace Rrhh.Presenters
{
    public class JobsPresenter : ModelsPresenter<Job>
    {
        public JobsPresenter(IEnumerable<Job> models) : base(models)
        {
        }

        protected override IEnumerable<PresentedModel> PresentModels()
        {
            _presentedModels = _presentedModels ?? _models.Select(x => new PresentedJob(x));
            return _presentedModels;
        }
    }

    public class PresentedJob : PresentedModel
    {
        public PresentedJob(BaseModel model) : base(model)
        {
        }

        private Job Job => Model as Job;
        public string Name => Job.Name;
        public string Description => Job.Description;
        public int Employees => Job.Employees.Count;
    }
}
