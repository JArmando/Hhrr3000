using System.Collections.Generic;
using Rrhh.Migrations;
using Rrhh.Models;

namespace Rrhh.Controllers
{
    public class EmployeesController
    {
        public RrhhContext Context { get; }

        public EmployeesController(RrhhContext context)
        {
            Context = context;
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
            return Create(newEmployee);
        }

        public Employee Create(Employee employee)
        {
            Context.Employees.Add(employee);
            Context.SaveChanges();
            return employee;
        }

        public IEnumerable<Employee> ListEmployees()
        {
            return Context.Employees;
        }
    }
}
