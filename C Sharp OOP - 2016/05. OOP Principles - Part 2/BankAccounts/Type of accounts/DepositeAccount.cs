using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class DepositeAccount : Account
    {
        public DepositeAccount(Customer depositeCustomer, decimal depositeBalance, decimal depositeInterestRate)
            : base(depositeCustomer, depositeBalance, depositeInterestRate)
        {
        }

        public override decimal Interest(int numberOfMonths)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0m;
            }
            else
            {
                return numberOfMonths * this.InterestRate;
            }
        }

        public void WithdrawMoney(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException("You can't withdraw this amount of money!");
            }
            this.Balance -= amount;
        }
    }
}
