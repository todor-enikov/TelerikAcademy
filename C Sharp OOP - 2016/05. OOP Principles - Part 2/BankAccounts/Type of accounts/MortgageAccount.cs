using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer mortgageCustomer, decimal mortgageBalance, decimal mortgageInterestRate)
            : base(mortgageCustomer, mortgageBalance, mortgageInterestRate)
        {
        }

        public override decimal Interest(int numberOfMonths)
        {
            if (numberOfMonths <= 6 && this.Customer.Type == "Indivdual")
            {
                return 0m;
            }
            if (numberOfMonths <= 12 && this.Customer.Type == "Company")
            {
                return 1 / 2;
            }
            return numberOfMonths * this.InterestRate;
        }

    }
}
