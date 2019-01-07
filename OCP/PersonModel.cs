using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
  public class PersonModel : IApplicantModel
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IAccounts AccountCreator { get; set; } = new Accounts();
  }
}
