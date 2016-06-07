using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rrhh.Models
{
    public class Candidate : Person, IModel
    {
        public int? ResumeId { get; set; }
        [Required]
        public virtual Resume Resume { get; set; }
        public decimal AspiringSalary { get; set; }
        [Required]
        public virtual JobOffer JobOfferAspiration { get; set; }
        public Guid? JobOfferAspirationId { get; set; }

        public new bool IsValid()
        {
            var valid = Resume.IsValid() && JobOfferAspiration.IsValid() && base.IsValid();
            Errors = Errors.Concat(Resume.Errors.Concat(JobOfferAspiration.Errors));
            return valid;
        }

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
