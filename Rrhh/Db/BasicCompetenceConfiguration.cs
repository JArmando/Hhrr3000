using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rrhh.Models;

namespace Rrhh.Db
{
    public class BasicCompetenceConfiguration : EntityTypeConfiguration<BasicCompetence>
    {
        public BasicCompetenceConfiguration()
        {
            Property(p => p.Id).HasColumnName("CompetenceId").IsRequired();
            ToTable("BasicCompetences");
        }
    }
}
