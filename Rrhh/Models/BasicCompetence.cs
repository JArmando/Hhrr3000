using System.Collections.Generic;

namespace Rrhh.Models
{
    public class BasicCompetence : Competence
    {
        public virtual ICollection<Resume> Resumes { get; set; }
    }
}
