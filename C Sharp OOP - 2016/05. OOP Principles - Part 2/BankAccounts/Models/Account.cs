using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer accountCustomer, decimal accountBalance, decimal accountInteresRate)
        {
            this.Customer = accountCustomer;
            this.Balance = accountBalance;
            this.InterestRate = accountInteresRate;
        }
        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                this.interestRate = value;
            }
        }

        public abstract decimal Interest(int numberOfMonths);

        public void Deposit(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("You can't deposit negative sum of money to your account");
            }
            this.Balance += amount;
        }

        public override string ToString()
        {
            return string.Format("This account customer is: {0}\nThis account has balance: {1}\nThis account has interest rate:{1}\n\n", this.Customer.Name, this.Balance, this.InterestRate);
        }

    }
}
