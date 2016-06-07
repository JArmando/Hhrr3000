using System;

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
