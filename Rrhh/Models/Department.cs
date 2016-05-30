using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rrhh.Models
{
    public class Department : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Job> JobPositions { get; set; }
        public virtual ICollection<JobOffer> JobOffers { get; set; }
    }
}
