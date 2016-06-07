using System.Collections.Generic;
using System.Linq;
using Rrhh.Models;

namespace Rrhh.Presenters
{
    public class DepartmentsPresenter : ModelsPresenter<Department>
    {
        public DepartmentsPresenter(IEnumerable<Department> models) : base(models)
        {
        }

        protected override IEnumerable<PresentedModel> PresentModels()
        {
            _presentedModels = _presentedModels ?? _models.Select(x => new PresentedDepartment(x));
            return _presentedModels;
        }
    }

    public class PresentedDepartment : PresentedModel
    {
        public PresentedDepartment(BaseModel model) : base(model){}

        private Department Department => Model as Department;

        public string Name => Department.Name;
        public string Description => Department.Description;
        public int Employees => Department.Employees.Count();
        //public int Vacancies => Department.JobOffers.Count;
        // TODO: handle vacancies
        public int JobPositions => Department.JobPositions.Count;
    }
}
