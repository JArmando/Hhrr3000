using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rrhh.Models;

namespace Rrhh.Db
{
    //public class PersonConfiguration : EntityTypeConfiguration<Person>
    //{
    //    public PersonConfiguration()
    //    {
    //        //Property(p => p.Id).HasColumnName("PersonId").IsRequired();
    //        Property(p => p.FirstName).IsRequired();
    //        Property(p => p.LastName).IsRequired();
    //        Property(p => p.Email).IsRequired();
    //        Property(p => p.Phone).IsRequired();
    //        Property(p => p.IsActive).IsRequired();
    //        Map(x => x.MapInheritedProperties().Property(p => p.Id).HasColumnName("PersonId"));
    //        ToTable("People");
    //    }
    //}
}
