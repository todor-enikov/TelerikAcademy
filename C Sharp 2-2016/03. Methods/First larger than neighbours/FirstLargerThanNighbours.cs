using System;
using System.Linq;

class FirstLargerThanNighbours
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(FirstElement(arrayOfNumbers));
    }
    static int FirstElement(int[] arrayOfNumbers)
    {

        for (int i = 1; i < arrayOfNumbers.Length; i++)
        {
            if (arrayOfNumbers[i] > arrayOfNumbers[i - 1] && arrayOfNumbers[i] > arrayOfNumbers[i + 1])
            {
                return i;
            }
        }
        return -1;

    }
}

