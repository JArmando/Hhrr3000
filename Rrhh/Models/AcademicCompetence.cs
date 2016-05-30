using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rrhh.Models
{
    public class AcademicCompetence : Competence
    {
        public string Level { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string AcademicInstitution { get; set; }
    }
}
