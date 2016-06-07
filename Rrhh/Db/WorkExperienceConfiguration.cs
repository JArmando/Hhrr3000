using System.Data.Entity.ModelConfiguration;
using Rrhh.Models;

namespace Rrhh.Db
{
    public class WorkExperienceConfiguration : EntityTypeConfiguration<WorkExperience>
    {
        public WorkExperienceConfiguration()
        {
            Property(p => p.Id).HasColumnName("WorkExperienceId").IsRequired();
            Property(p => p.Description).IsRequired();
            Property(p => p.InstitutionName).IsRequired();
            Property(p => p.Salary).IsOptional();
            Property(p => p.StartDate).IsRequired();
            Property(p => p.EndDate).IsRequired();
            Property(p => p.JobPosition).IsRequired();
        }
    }
}
