﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class Individual : Customer
    {
        public Individual(string nameIndividual)
            : base(nameIndividual, "Individual")
        {
        }
    }
}
