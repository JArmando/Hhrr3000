using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Rrhh.Models
{
    public class Department : BaseModel
    {
        #region Mapped properties
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        #endregion

        #region UnMapped Properties
        public virtual ICollection<Job> JobPositions { get; set; }
        public virtual ICollection<JobOffer> JobOffers { get; set; }
        public virtual IEnumerable<Employee> Employees => JobPositions.SelectMany(x => x.Employees);
        #endregion
    }
}
