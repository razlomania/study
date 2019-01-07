using System;

namespace Liskov
{
  class Program
  {
    static void Main(string[] args)
    {
      Manager accountingVP = new Manager();

      accountingVP.FirstName = "Emma";
      accountingVP.LastName = "Stone";
      accountingVP.CalculatePerHourRate(4);

      BaseEmployee emp = new CEO();

      emp.FirstName = "Tim";
      emp.LastName = "Corney";
      //emp.AssignManager(accountingVP);
      emp.CalculatePerHourRate(2);

      Console.WriteLine($"{emp.FirstName} salary = {emp.Salary}");

      Console.ReadKey();
    }
  }
}
