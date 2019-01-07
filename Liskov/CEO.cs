using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov
{
  public class CEO : BaseEmployee, IManager
  {
    public override void CalculatePerHourRate(int rank)
    {
      base.CalculatePerHourRate(rank);
    }

    public void GeneratePerformanceReview()
    {
      Console.WriteLine("Perform Review");
    }

    public void FireSomeone()
    {
      Console.WriteLine("You are fired");
    }
  }
}
