using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rrhh.Migrations;
using Rrhh.Models;

namespace Rrhh.Controllers
{
    public class JobOffersController
    {
        public RrhhContext Context { get; }

        public JobOffersController(RrhhContext context)
        {
            Context = context;
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
    }
}
