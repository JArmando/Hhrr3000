using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rrhh.Models
{
    public class Candidate : Person
    {
        public int? ResumeId { get; set; }
        public virtual Resume Resume { get; set; }
        public decimal AspiringSalary { get; set; }
        public JobOffer JobOfferAspiration { get; set; }
    }
}
