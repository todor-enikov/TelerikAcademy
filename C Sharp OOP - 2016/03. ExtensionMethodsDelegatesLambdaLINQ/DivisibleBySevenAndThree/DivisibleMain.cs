using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBySevenAndThree
{
    class DivisibleMain
    {
        static void Main()
        {
            int[] numbers = new int[] { 14, 21, 3, 42, 5, 566, 7 };

            Console.WriteLine("Divisible with Lambda.");
            var divisibleNumbers = numbers.DivisibleLambda();
            foreach (var number in divisibleNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Divisible with LINQ.");
            var divisibleNumbersLINQ = numbers.DivisibleLINQ();
            foreach (var number in divisibleNumbersLINQ)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

        }
    }
}
