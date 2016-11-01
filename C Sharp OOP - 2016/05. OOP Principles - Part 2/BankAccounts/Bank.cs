using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class Bank
    {
        private string nameOfBank;
        private List<Customer> customers;
        private List<Account> accounts;

        public Bank(string name,List<Customer> customersInBank,List<Account> accountsInBank)
        {
            this.NameOfBank = name;
            this.Customers = customersInBank;
            this.Accounts = accountsInBank;
        }

        public string NameOfBank
        {
            get
            {
                return this.nameOfBank;
            }
            set
            {
                this.nameOfBank = value;
            }
        }

        public List<Customer> Customers
        {
            get
            {
                return this.customers;
            }
            set
            {
                this.customers = value;
            }
        }

        public List<Account> Accounts
        {
            get
            {
                return this.accounts;
            }
            set
            {
                this.accounts = value;
            }
        }

    }
}
