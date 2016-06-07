using System.Collections.Generic;
using System.Data.Entity.Migrations;
using Rrhh.Migrations;
using Rrhh.Models;

namespace Rrhh.Controllers
{
    public class EmployeesController : BaseController<Employee>
    {

        public EmployeesController(RrhhContext context) : base(context, context.Employees)
        {
        }

        public Employee New(string firstName, string lastName, string governmentIssuedId, string email,
            string phoneNumber, decimal aspiringSalary)
        {
            return new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Phone = phoneNumber,
                GovernmentIssuedId = governmentIssuedId,
            };
        }

        public Employee New(string firstName, string lastName, string governmentIssuedId, string email,
            string phoneNumber, decimal aspiringSalary, Job job)
        {
            var newEmployee = New(firstName, lastName, governmentIssuedId, email, phoneNumber, aspiringSalary);
            newEmployee.Job = job;
            return newEmployee;
        }

        public Employee Create(string firstName, string lastName, string governmentIssuedId, string email,
            string phoneNumber, decimal aspiringSalary, Job job)
        {
            var newEmployee = New(firstName, lastName, governmentIssuedId, email, phoneNumber, aspiringSalary, job);
            DoCreate(newEmployee);
            return newEmployee;
        }

        public Employee Update(Employee employee)
        {
            // Need to figure out a way to do this in a more generic way
            // TODO: move it to the BaseController
            if (employee.IsValid()) Context.Employees.AddOrUpdate(employee); Context.SaveChanges();

            return employee;
        }

        public bool Delete(Employee employee)
        {
            Dbset.Remove(employee);
            Context.SaveChanges();
            return true;
        }

        public static bool Delete(RrhhContext context, Employee employee)
        {
            return new EmployeesController(context).Delete(employee);
        }

        public IEnumerable<Employee> List()
        {
            return Context.Employees;
        }
    }
}
