using System.Collections.Generic;

namespace Rrhh.Models
{
    public class Language : Competence
    {
        public int Level { get; set; }
        public virtual ICollection<Resume> Resumes { get; set; }
    }
}
