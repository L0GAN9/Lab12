using System;

class CheckingAccount : BankAccount
{
  public static void CalculateInterest()
  {
    Console.WriteLine("Enter Age of Account in Years");
    int years = Convert.ToInt32(Console.ReadLine());
    double Balance = 1000;
    double interest = (Balance * .05 * years);
    Balance = (Balance + interest);
    Console.WriteLine(Balance);
  }
  public static void Withdraw()
  {
    BankAccount.Withdraw();
  }
}