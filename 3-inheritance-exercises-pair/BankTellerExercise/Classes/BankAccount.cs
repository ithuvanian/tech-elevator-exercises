using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        string accountNumber;
        DollarAmount balance;

        public string AccountNumber { get; set; }
        public DollarAmount Balance
        {
            get
            {
                return balance;
            }
        }

        public BankAccount()
        {
            balance = new DollarAmount(0);
        }

        public DollarAmount Deposit(DollarAmount amountToDeposit)
        {
            int existingAmount = (balance.Dollars * 100) + balance.Cents;
            int depositAmount = (amountToDeposit.Dollars * 100) + amountToDeposit.Cents;
            int newAmount = existingAmount + depositAmount;
            balance = new DollarAmount(newAmount);
            return balance;
        }

        public virtual DollarAmount Withdraw(DollarAmount amountToWithdraw)
        {
            int existingAmount = (balance.Dollars * 100) + balance.Cents;
            int withdrawAmount = (amountToWithdraw.Dollars * 100) + amountToWithdraw.Cents;
            int newAmount = existingAmount - withdrawAmount;
            balance = new DollarAmount(newAmount);
            return balance;
        }

        public void Transfer(BankAccount destinationAccount, DollarAmount transferAmount)
        {

            destinationAccount.Deposit(transferAmount);
            this.Withdraw(transferAmount);
        }

        

        //public int GetCents()C:\Users\apappa\alexanderpappa-c-exercises\team6-c-week3-pair-exercise\m1-w3d2-inheritance-exercises-pair\BankTellerExercise\Classes\BankAccount.cs
        //{
        //    return this.balance.Cents;
        //}

}
}
