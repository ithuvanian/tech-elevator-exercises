using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class BankCustomer
    {
        private string name;
        private string address;
        private string phoneNumber;
        private List<BankAccount> accountList = new List<BankAccount>();

        public string Name
        { get; set; }
        public string Address
        { get; set; }
        public string PhoneNumber
        { get; set; }
        public BankAccount[] AccountList
        {
            get
            {
                return accountList.ToArray();
            }
        }
        public void AddAccount(BankAccount newAccount)
        {
            //newAccount = new BankAccount();
            accountList.Add(newAccount);
        }

        public BankCustomer(string name, string address, string phoneNumber)
        {
            this.name = Name;
            this.address = Address;
            this.phoneNumber = PhoneNumber;
        }

        public bool IsVip()
        {
            decimal totalDollars = 0;
            foreach (BankAccount item in accountList)
            {
                totalDollars += item.Balance.TotalAmountInCents;

            }
            if (totalDollars >= 2500000)
            {
                return true;
            }
            return false;
        }
    }
}
