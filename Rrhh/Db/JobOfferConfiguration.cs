using System.Data.Entity.ModelConfiguration;
using Rrhh.Models;

namespace Rrhh.Db
{
    public class JobOfferConfiguration : EntityTypeConfiguration<JobOffer>
    {
        public JobOfferConfiguration()
        {
            Property(p => p.Id).HasColumnName("JobOfferId");
            Property(p => p.MaxSalary).IsRequired();
            Property(p => p.MinSalary).IsRequired();
            Property(p => p.RiskLevel).IsRequired();
            Property(p => p.IsActive).IsRequired();

            HasRequired(p => p.Job);

            ToTable("JobOffers");
        }
    }
}
