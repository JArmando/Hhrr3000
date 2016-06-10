using System;
using System.ComponentModel.DataAnnotations;

namespace Rrhh.Models
{
    public class JobOffer : BaseModel
    {
        [Required]
        public string RiskLevel { get; set; }
        [Required]
        public decimal MinSalary { get; set; }
        [Required]
        public decimal MaxSalary { get; set; }
        public Guid JobId { get; set; }
        [Required]
        public virtual Job Job { get; set; }
    }
}
