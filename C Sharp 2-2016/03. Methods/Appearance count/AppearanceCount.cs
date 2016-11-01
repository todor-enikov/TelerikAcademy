using System;
using System.Linq;

class AppearanceCount
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int numberX = int.Parse(Console.ReadLine());
        Console.WriteLine(CountNumberX(arrayOfNumbers, numberX));
    }
    static int CountNumberX(int[] arrayOfNumbers, int numberX)
    {
        int counter = 0;
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            if (numberX == arrayOfNumbers[i])
            {
                counter++;
            }
        }
        return counter;
    }
}

