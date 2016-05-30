using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
