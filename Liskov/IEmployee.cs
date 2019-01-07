namespace Liskov
{
  public interface IEmployee
  {
    string FirstName { get; set; }
    string LastName { get; set; }
    decimal Salary { get; set; }

    void CalculatePerHourRate(int i);
  }
}