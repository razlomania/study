using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov
{
  public interface IManager : IEmployee
  {
    void GeneratePerformanceReview();
  }
}
