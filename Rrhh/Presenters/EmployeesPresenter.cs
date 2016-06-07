﻿using System.Collections.Generic;
using System.Linq;
using Rrhh.Models;

namespace Rrhh.Presenters
{
    public class EmployeesPresenter
    {
        private IEnumerable<Employee> _employees;
        public IEnumerable<PresentedEmployee> Employees => Present();
        private IEnumerable<PresentedEmployee> _presentedCandidates;
        public EmployeesPresenter(IEnumerable<Employee> employees)
        {
            _employees = employees;
        }

        private IEnumerable<PresentedEmployee> Present()
        {
            _presentedCandidates = _presentedCandidates ?? _employees.Select(x => new PresentedEmployee(x));
            return _presentedCandidates;
        }

    }

    public class PresentedEmployee : PresentedModel
    {
        public PresentedEmployee(BaseModel model) : base(model)
        {
        }

        private Employee Employee => Model as Employee;
        private Job _job => Employee.Job;
        private Department _department => _job.Department;

        public string Name => Employee.FirstName + " " + Employee.LastName;
        public string PhoneNumber => Employee.Phone;
        public string Job => _job.Name;
        public string Department => _department.Name;
        public string SocialId => Employee.GovernmentIssuedId;
    }
}