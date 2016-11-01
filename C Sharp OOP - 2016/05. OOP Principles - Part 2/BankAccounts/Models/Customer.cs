using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public abstract class Customer
    {
        private string name;
        private string type;

        public Customer(string nameOfCustomer, string typeOfCustomer)
        {
            this.Name = nameOfCustomer;
            this.Type = typeOfCustomer;
        }
        public string Name { get { return this.name; } set { this.name = value; } }

        public string Type { get { return this.type; } set { this.type = value; } }

        public override string ToString()
        {
            return string.Format("There is customer with name: {0}\nAnd his type is: {1}\n\n", this.Name, this.Type);
        }
    }
}
