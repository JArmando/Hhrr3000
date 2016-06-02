using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        public JobOffer JobOfferAspiration { get; set; }

        public static explicit operator Employee(Candidate c)
        {
            var newEmployee = new Employee
            {
                FirstName = c.FirstName,
                LastName = c.LastName,
                Email = c.Email,
                GovernmentIssuedId = c.GovernmentIssuedId,
                Job = c.JobOfferAspiration.Job,
                Phone = c.Phone
            };
            
            return newEmployee;
        }
    }
}
