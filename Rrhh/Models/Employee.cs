using System;

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
