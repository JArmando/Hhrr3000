using System.Data.Entity.ModelConfiguration;
using Rrhh.Models;

namespace Rrhh.Db
{
    public class JobConfiguration : EntityTypeConfiguration<Job>
    {
        public JobConfiguration()
        {
            Property(p => p.Id).HasColumnName("JobId");
            Property(p => p.Name).IsRequired();
            Property(p => p.Description).IsRequired();
            HasRequired(p => p.Department);
        }
    }
}
