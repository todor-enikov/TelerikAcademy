using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class LoanAccount : Account
    {

        public LoanAccount(Customer loanCustomer, decimal loanBalance, decimal loanInterestRate)
            : base(loanCustomer, loanBalance, loanInterestRate)
        {
        }

        public override decimal Interest(int numberOfMonths)
        {
            if (numberOfMonths < 3 && this.Customer.Type == "Individual")
            {
                return 0m;
            }
            if (numberOfMonths < 2 && this.Customer.Type == "Company")
            {
                return 0m;
            }
            return numberOfMonths * this.InterestRate;
        }
    }
}
