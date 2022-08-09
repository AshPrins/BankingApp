using BankLibrary;
using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //account is object, calling class Bankaccount
            var account = new BankAccount("Kendra", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);

            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);

            
            account.MakeWithdrawal(50, DateTime.Now, "Xbox");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());

        }
        

    }
}


