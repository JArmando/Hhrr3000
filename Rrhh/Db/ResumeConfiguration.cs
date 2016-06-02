using System.Data.Entity.ModelConfiguration;
using Rrhh.Models;

namespace Rrhh.Db
{
    public class ResumeConfiguration : EntityTypeConfiguration<Resume>
    {
        public ResumeConfiguration()
        {
            Property(p => p.Id).HasColumnName("ResumeId");
            Property(p => p.RecommendedById).IsOptional();

            HasMany(p => p.Competences).WithMany();
            HasMany(p => p.Languages).WithOptional();
            HasMany(p => p.WorkExperiences).WithMany();

            ToTable("Resumes");
        }
    }
}
