using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
  public class ManagerModel : IApplicantModel
  {
    public string FirstName { get ; set ; }
    public string LastName { get ; set ; }
    public IAccounts AccountCreator { get; set; } = new ManagerAccounts();
  }
}
