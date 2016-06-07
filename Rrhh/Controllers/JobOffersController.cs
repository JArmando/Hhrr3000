using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rrhh.Migrations;
using Rrhh.Models;

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
    }
}
