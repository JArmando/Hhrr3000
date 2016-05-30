using System.Data.Entity.ModelConfiguration;
using Rrhh.Models;

namespace Rrhh.Db
{
    public class AcademicCompetenceConfiguration : EntityTypeConfiguration<AcademicCompetence>
    {
        public AcademicCompetenceConfiguration()
        {
            Property(p => p.Id).HasColumnName("AcademicCompetenceId");
            Property(p => p.AcademicInstitution).IsRequired();
            Property(p => p.StartDate).IsRequired();
            Property(p => p.Level).IsOptional();
            Property(p => p.FinishDate).IsOptional();
            ToTable("AcademicCompetences");
        }
    }
}
