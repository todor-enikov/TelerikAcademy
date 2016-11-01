using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
class Factorial
{
    static void Main()
    {
        long numberN = long.Parse(Console.ReadLine());
        List<long> arrayOfNumbers = new List<long>();
        Console.WriteLine(AddingElementsToList(numberN, arrayOfNumbers));
    }
    static BigInteger AddingElementsToList(long NumberN, List<long> arrayOfNumbers)
    {
        BigInteger factorial = 1;

        do
        {
            arrayOfNumbers.Add(NumberN);
            NumberN--;
        } while (NumberN > 0);

        for (int i = 0; i < arrayOfNumbers.Count; i++)
        {
            factorial *= arrayOfNumbers[i];
        }
        return factorial;
    }
}

