using System.Data.Entity.ModelConfiguration;
using Rrhh.Models;

namespace Rrhh.Db
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            Property(p => p.Id).HasColumnName("EmployeeId");
            Property(p => p.HireDate);
            Property(p => p.Salary).IsRequired();

            HasRequired(p => p.Job);

            ToTable("Employees");
        }
    }
}
