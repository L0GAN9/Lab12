using System;

class SavingsAccount : BankAccount
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
         double balance = 1000;
         Console.WriteLine("Enter Withdraw Amount");
         double amount = Convert.ToDouble(Console.ReadLine());
         if (balance > amount)
         {
           Console.WriteLine("New Balance is " + (balance - amount));
         }
         else
         {
           BankAccount.Withdraw();
         }
        }
}