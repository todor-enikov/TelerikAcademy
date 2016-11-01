using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    class GenericTypes
    {
        static void Main()
        {
            Console.WriteLine("Generic class");
            GenericClass<int> numbers = new GenericClass<int>();
            numbers.AddingElement(1);
            numbers.AddingElement(2);
            numbers.AddingElement(3);
            numbers.AddingElement(4);
            numbers.AddingElement(5);
            Console.WriteLine(numbers.ToString());

            Console.WriteLine("Remove element at position 2.");
            numbers.Remove(2);
            Console.WriteLine(numbers.ToString());

            Console.WriteLine("Insert element at position 2.");
            numbers.InsertElement(2, 3);
            Console.WriteLine(numbers.ToString());

            Console.WriteLine("Index of element with value 4 is: {0}", numbers.IndexOf(4));

            Console.WriteLine("The min element is: {0}", numbers.Min());
            Console.WriteLine("The max element is: {0}", numbers.Max());

        }
    }
}
