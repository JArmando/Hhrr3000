using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Rrhh.Models
{
    public class Job : BaseModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public Guid DepartmentId { get; set; }
        [Required]
        public virtual Department Department { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

        public new bool IsValid()
        {
            var result = Department.IsValid() && base.IsValid();
            Errors = Errors.Concat(Department.Errors);
            return result;
        }
    }
}
