using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov
{
  public class Employee : BaseEmployee, IManaged
  {
    public IEmployee Manager { get; set; }

    public void AssignManager(IEmployee manager)
    {
      Manager = manager;
    }

  }
}
