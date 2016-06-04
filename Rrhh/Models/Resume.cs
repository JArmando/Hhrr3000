using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rrhh.Models
{
    public class Resume : BaseModel
    {
        public Guid? RecommendedById { get; set; }
        public virtual Employee RecommendedBy { get; set; }
        [Required]
        public virtual ICollection<BasicCompetence> Competences { get; set; }
        [Required]
        public virtual ICollection<Language> Languages { get; set; }
        [Required]
        public virtual ICollection<WorkExperience> WorkExperiences { get; set; }
    }
}
