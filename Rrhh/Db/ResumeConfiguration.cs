using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rrhh.Models;

namespace Rrhh.Db
{
    public class ResumeConfiguration : EntityTypeConfiguration<Resume>
    {
        public ResumeConfiguration()
        {
            Property(p => p.Id).HasColumnName("ResumeId");
            HasOptional(p => p.Competences).WithMany();
            HasOptional(p => p.Languages).WithMany();
            ToTable("Resumes");
        }
    }
}
