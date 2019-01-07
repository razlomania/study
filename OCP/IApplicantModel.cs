namespace OCP
{
  public interface IApplicantModel
  {
    string FirstName { get; set; }
    string LastName { get; set; }
    IAccounts AccountCreator { get; set; }
  }
}