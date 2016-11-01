using System;
using System.Linq;

class LargerThanNeighbour
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(CheckElements(arrayOfNumbers));
    }

    static int CheckElements(int[] arrayOfNumbers)
    {
        int counter = 0;
        for (int i = 1; i < arrayOfNumbers.Length - 1; i++)
        {
            if (arrayOfNumbers[i] > arrayOfNumbers[i - 1] && arrayOfNumbers[i] > arrayOfNumbers[i + 1])
            {
                counter++;
            }
        }
        return counter;
    }
}

