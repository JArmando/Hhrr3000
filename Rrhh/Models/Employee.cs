using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rrhh.Models
{
    public class Employee : Person
    {
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public Guid JobId { get; set; }
        public virtual Job Job { get; set; }
    }
}
