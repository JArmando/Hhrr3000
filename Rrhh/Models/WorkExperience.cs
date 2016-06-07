using System;
using System.Collections.Generic;

namespace Rrhh.Models
{
    public class WorkExperience : BaseModel
    {
        public string InstitutionName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string JobPosition { get; set; }
        public string Description { get; set; }
        public decimal Salary { get; set; }
        public virtual ICollection<Resume> Resumes { get; set; }
    }
}
