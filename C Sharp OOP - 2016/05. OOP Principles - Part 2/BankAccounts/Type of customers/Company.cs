﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class Company : Customer
    {
        public Company(string nameCompany)
            : base(nameCompany, "Company")
        {
        }
    }
}
