using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests
{
    [TestClass]
    public class BankCustomerTest
    {
        [TestMethod]
        public void IsVIPTest()
        {
            BankAccount newAccount = new BankAccount();
            BankCustomer thisCustomer = new BankCustomer("Steve", "100 Steeve Lane", "123456789");
            DollarAmount thisDeposit = new DollarAmount(300000);
            thisCustomer.AddAccount(newAccount);
            newAccount.Deposit(thisDeposit);
            bool result = thisCustomer.IsVip();
            Assert.AreEqual(false, result);

            DollarAmount newDeposit = new DollarAmount(2200000);
            newAccount.Deposit(newDeposit);
            bool newtest = thisCustomer.IsVip();
            Assert.AreEqual(true, newtest);
        }
    }
}
