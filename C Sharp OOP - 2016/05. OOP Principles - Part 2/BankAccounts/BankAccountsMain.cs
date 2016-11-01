using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class BankAccountsMain
    {
        static void Main()
        {
            var accounts = new List<Account>();
            accounts.Add(new LoanAccount(new Individual("Georgi Ivanov"), 100m, 5));
            accounts.Add(new MortgageAccount(new Company("Alianz"), 100000m, 13));
            accounts.Add(new DepositeAccount(new Individual("Marto Tankista"), 18m, 4));

            var customers = new List<Customer>();
            customers.Add(new Individual("Gosho ot pochivka"));
            customers.Add(new Company("Golema firma"));

            var bank = new Bank("Banka KTB", customers, accounts);
            Console.WriteLine("Accounts in bank");
            foreach (var account in accounts)
            {
                Console.WriteLine(account);
            }
            Console.WriteLine("Customers in bank");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
