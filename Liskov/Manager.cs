using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov
{
  public class Manager : Employee, IManager
  {
    public override void CalculatePerHourRate(int rank)
    {
      decimal baseAmount = 19.50M;

      Salary = baseAmount + (rank * 4);
    }

    public void GeneratePerformanceReview()
    {
      Console.WriteLine("I am reviewing a reports");
    }
  }
}
