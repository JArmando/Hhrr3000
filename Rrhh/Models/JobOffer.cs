using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rrhh.Models
{
    public class JobOffer : BaseModel
    {
        public string RiskLevel { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public Guid JobId { get; set; }
        public virtual Job Job { get; set; }
    }
}
