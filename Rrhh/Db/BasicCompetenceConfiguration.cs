using System.Data.Entity.ModelConfiguration;
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
