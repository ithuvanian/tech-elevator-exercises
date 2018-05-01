using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        public override DollarAmount Withdraw(DollarAmount amountToWithdraw)
        {
            int existingAmount = (Balance.Dollars * 100) + Balance.Cents;
            int withdrawAmount = (amountToWithdraw.Dollars * 100) + amountToWithdraw.Cents;
            int newAmount = existingAmount - withdrawAmount;
            if (newAmount < 0)
            {
                newAmount -= 1000;
                if (newAmount < -10000)
                {
                    return Balance;
                }
            }
            DollarAmount afterWithdraw = new DollarAmount(newAmount);
            return afterWithdraw;
        }
    }
}
