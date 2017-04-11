using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryPasswords
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var number = Console.ReadLine();
            var counter = 0;
            foreach (var item in number)
            {
                if (item == '*')
                {
                    counter++;
                }
            }

            long result = 1;
            for (double i = 0; i < counter; i++)
            {
                result += (long)Math.Pow(2.0, i);
            }

            Console.WriteLine(result);
        }
    }
}
