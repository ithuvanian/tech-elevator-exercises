using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public override DollarAmount Withdraw(DollarAmount amountToWithdraw)
        {
            int existingAmount = (Balance.Dollars * 100) + Balance.Cents;
            int withdrawAmount = (amountToWithdraw.Dollars * 100) + amountToWithdraw.Cents;
            if (withdrawAmount > existingAmount)
            {
                return Balance;
            }
            else if (existingAmount < 15000)
            {
                withdrawAmount += 200;
            }
            int newAmount = existingAmount - withdrawAmount;
            DollarAmount lowerBalance = new DollarAmount(newAmount);
            return lowerBalance;
        }
    }
}
