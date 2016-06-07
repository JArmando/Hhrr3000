using System.Data.Entity.ModelConfiguration;
using Rrhh.Models;

namespace Rrhh.Db
{
    public class CandidateConfiguration : EntityTypeConfiguration<Candidate>
    {
        public CandidateConfiguration()
        {
            Property(p => p.Id).HasColumnName("CandidateId").IsRequired();
            Property(p => p.ResumeId);
            HasOptional(p => p.JobOfferAspiration);
            ToTable("Candidates");
        }
    }
}
