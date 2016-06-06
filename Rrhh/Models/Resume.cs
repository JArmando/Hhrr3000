using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Rrhh.Models
{
    public class Resume : BaseModel
    {
        public Guid? RecommendedById { get; set; }
        public virtual Employee RecommendedBy { get; set; }

        public virtual ICollection<BasicCompetence> Competences { get; set; } = new List<BasicCompetence>();

        public virtual ICollection<Language> Languages { get; set; } = new List<Language>();

        public virtual ICollection<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();
    }
}
