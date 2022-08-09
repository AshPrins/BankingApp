using BankLibrary;
using System;
using Xunit;

namespace BankingTest
{
    public class BasicTests
    {
        [Fact]
        public void Test1()
        {
            //test if true is true
            Assert.True(true);

        }

        [Fact]
        public void Test2()
        {
            // Test for a negative balance.
            var account = new BankAccount("Kendra", 1000);
            
            Assert.Throws<InvalidOperationException>(
                
                ()=> account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw")
                );
        }

        [Fact]
        public void Test3()
        {
            //BankAccount invalidAccount;
            Assert.Throws<ArgumentOutOfRangeException>(

                ()=>new BankAccount("invalid", -55)
                );
        }
    }
}

//no writeline needed for testing
//no try and catch needed for testing
//// Test for a negative balance.
//try
//{
//    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
//}
//catch (InvalidOperationException e)
//{

//    //no writeline needed for testing
//    //Console.WriteLine("Exception caught trying to overdraw");
//    //Console.WriteLine(e.ToString());
//}

//// Test that the initial balances must be positive.
//BankAccount invalidAccount;
//try
//{
//    invalidAccount = new BankAccount("invalid", -55);
//}
//catch (ArgumentOutOfRangeException e)
//{
//    Console.WriteLine("Exception caught creating account with negative balance");
//    Console.WriteLine(e.ToString());
//    return;
//}