using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void BankDepositTest()
        {
            BankAccount thisBankAccount = new BankAccount();
            DollarAmount addingThis = new DollarAmount(555);
            DollarAmount newBalance = thisBankAccount.Deposit(addingThis);
            Assert.AreEqual(555, (newBalance.Dollars * 100) + newBalance.Cents);
        }

        [TestMethod]
        public void BankWithdrawalTest()
        {
            BankAccount thisBankAccount = new BankAccount();
            DollarAmount initialDeposit = new DollarAmount(555);
            thisBankAccount.Deposit(initialDeposit);
            DollarAmount withdrawingThis = new DollarAmount(444);
            DollarAmount newBalance = thisBankAccount.Withdraw(withdrawingThis);
            Assert.AreEqual(111, (newBalance.Dollars * 100) + newBalance.Cents);
        }

        [TestMethod]
        public void BankTransferTest()
        {
            BankAccount originAccount = new BankAccount();
            DollarAmount initialBalance = new DollarAmount(333);
            originAccount.Deposit(initialBalance);
            BankAccount destinationAccount = new BankAccount();
            DollarAmount transferAmount = new DollarAmount(111);
            originAccount.Transfer(destinationAccount, transferAmount);
            DollarAmount originAfterTransfer = new DollarAmount(222);
            Assert.AreEqual(222, (originAccount.Balance.Dollars * 100) + originAccount.Balance.Cents);
            Assert.AreEqual(111, (destinationAccount.Balance.Dollars * 100) + destinationAccount.Balance.Cents);
        }

        [TestMethod]
        public void CheckingAccountOverdraftTest()
        {
            CheckingAccount thisAccount = new CheckingAccount();
            DollarAmount withdrawAmount = new DollarAmount(10);
            DollarAmount lowerBalance = thisAccount.Withdraw(withdrawAmount);
            Assert.AreEqual(-1010, lowerBalance.Dollars * 100 + lowerBalance.Cents);
        }

        [TestMethod]
        public void CheckingAccountMegaOverdraftTest()
        {
            CheckingAccount thisAccount = new CheckingAccount();
            DollarAmount withdrawAmount = new DollarAmount(11111);
            DollarAmount lowerBalance = thisAccount.Withdraw(withdrawAmount);
            Assert.AreEqual(0, lowerBalance.Dollars * 100 + lowerBalance.Cents);
        }

        [TestMethod]
        public void SavingsAccountWithdrawTest()
        {
            SavingsAccount thisAccount = new SavingsAccount();
            DollarAmount smallDeposit = new DollarAmount(250);
            thisAccount.Deposit(smallDeposit);
            DollarAmount withdrawAmount = new DollarAmount(10);
            DollarAmount lowerBalance = thisAccount.Withdraw(withdrawAmount);
            Assert.AreEqual(40, lowerBalance.Dollars * 100 + lowerBalance.Cents);
        }

        [TestMethod]
        public void SavingsAccountOverdraftTest()
        {
            SavingsAccount thisAccount = new SavingsAccount();
            DollarAmount withdrawAmount = new DollarAmount(10);
            DollarAmount lowerBalance = thisAccount.Withdraw(withdrawAmount);
            Assert.AreEqual(0, lowerBalance.Dollars * 100 + lowerBalance.Cents);
        }

        //[TestMethod]
        //public void GetCentsTest()
        //{
        //    BankAccount thisBankAccount = new BankAccount();
        //    Assert.AreEqual(0, thisBankAccount.GetCents() );
        //}

    }
}
