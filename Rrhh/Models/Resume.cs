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
    }
}
