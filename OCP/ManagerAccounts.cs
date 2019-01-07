using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
  public class ManagerAccounts : IAccounts
  {
    public EmployeeModel Create(IApplicantModel person)
    {
      EmployeeModel employee = new EmployeeModel();

      employee.FirstName = person.FirstName;
      employee.LastName = person.LastName;
      employee.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@gmail.com";

      employee.IsManager = true;

      return employee;
    }
  }
}
