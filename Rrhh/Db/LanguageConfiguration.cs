using System.Data.Entity.ModelConfiguration;
using Rrhh.Models;

namespace Rrhh.Db
{
    public class LanguageConfiguration : EntityTypeConfiguration<Language>
    {
        public LanguageConfiguration()
        {
            Property(p => p.Id).HasColumnName("LanguageId");
            Property(p => p.Level).IsRequired();
            Property(p => p.IsActive).IsRequired();
            ToTable("Languages");
        }
    }
}
