using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rrhh.Models;

namespace Rrhh.Db
{
    public class CandidateConfiguration : EntityTypeConfiguration<Candidate>
    {
        public CandidateConfiguration()
        {
            Property(p => p.Id).HasColumnName("CandidateId").IsRequired();
            Property(p => p.ResumeId);
            ToTable("Candidates");
        }
    }
}
