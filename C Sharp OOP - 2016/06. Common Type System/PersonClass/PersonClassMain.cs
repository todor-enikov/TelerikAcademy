using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class PersonClassMain
    {
        static void Main()
        {
            Person pesho = new Person("Pesho");
            Person aivan = new Person("Aivan",43);

            Console.WriteLine(pesho.ToString());
            Console.WriteLine(aivan.ToString());
            
        }
    }
}
