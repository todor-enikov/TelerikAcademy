using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_extensions
{
    public class IEnumerableTesting
    {
        public static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            Console.WriteLine("The sum of the collection is: {0}",numbers.Sum());
            Console.WriteLine("The product of the collection is: {0}", numbers.Product());
            Console.WriteLine("The min element in the collection is: {0}", numbers.Min());
            Console.WriteLine("The max element in the collection is: {0}", numbers.Max());
            Console.WriteLine("The average of the collection is: {0}", numbers.Average());
            Console.WriteLine();
            Console.WriteLine("If you want you can try with another IEnumerable collections!");

        }
    }
}
