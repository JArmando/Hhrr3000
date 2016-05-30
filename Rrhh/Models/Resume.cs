using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rrhh.Models
{
    public class Resume : BaseModel
    {
        public Guid? RecommendedById { get; set; }
        public virtual Employee RecommendedBy { get; set; }
        public virtual ICollection<BasicCompetence> Competences { get; set; }
        public virtual ICollection<Language> Languages { get; set; }
        public virtual ICollection<WorkExperience> WorkExperiences { get; set; }
    }
}
