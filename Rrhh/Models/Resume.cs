using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rrhh.Models
{
    public class Resume : BaseModel
    {
        public ICollection<BasicCompetence> Competences { get; set; }
        public ICollection<Language> Languages { get; set; }
        public ICollection<WorkExperience> WorkExperiences { get; set; }
        public Guid? RecommendedById { get; set; }
        public virtual Employee RecommendedBy { get; set; }
    }
}
