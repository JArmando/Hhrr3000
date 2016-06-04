using System.Collections.Generic;
using Rrhh.Migrations;
using Rrhh.Models;

namespace Rrhh.Controllers
{
    public class EmployeesController : BaseController
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

        public IEnumerable<Employee> ListEmployees()
        {
            return Context.Employees;
        }
    }
}
