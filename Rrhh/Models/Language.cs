using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rrhh.Models
{
    public class Language : Competence
    {
        public int Level { get; set; }
        public virtual ICollection<Resume> Resumes { get; set; }
    }
}
