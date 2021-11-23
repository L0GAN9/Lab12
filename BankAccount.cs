 using System;
 
 abstract class BankAccount
    {
        public string AcctNbr { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public bool DateTime { get; set; }
        public bool DateCreated { get; set; }

        public BankAccount()
        {
          Balance = 1000;
        }

         public BankAccount(double balance)
        {
          balance = Balance;
        }

        public static void Deposit(double amount = 0, double balance = 1000)
        { 
          Console.WriteLine("Enter Deposit Amount");
          amount = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("New Balance is " + (balance + amount));

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
           Console.WriteLine("Insufficent Funds");
           Console.WriteLine("Balance - " + balance);
         }
         
        }
    }