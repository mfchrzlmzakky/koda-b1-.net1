namespace Banking.Console.Models;

public class Account
{
  public string AccountNumber;
  public string Name;
  public int Balance;

  public Account(string accountNumber, string name, int balance)
  {
    if (String.IsNullOrWhiteSpace(accountNumber))
    {
      throw new ArgumentException("Account Number is required!");
    }
    if (String.IsNullOrWhiteSpace(name))
    {
      throw new ArgumentException("Name is required!");
    }
    if (balance <= 0)
    {
      throw new ArgumentException("Balance must be positive!");
    }
    AccountNumber = accountNumber;
    Name = name;
    Balance = balance;
  }

  public string getAccount()
  {
    return $"Account Number: {AccountNumber}\nName: {Name}\nBalance: {Balance}";
  }
}