using System;
using System.Collections.Generic;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        ArraySorting(arrayOfNumbers);
        Console.Write(string.Join(" ", arrayOfNumbers));

    }
    static void ArraySorting(int[] arrayOfNumbers)
    {
        Array.Sort(arrayOfNumbers);
    }
}

