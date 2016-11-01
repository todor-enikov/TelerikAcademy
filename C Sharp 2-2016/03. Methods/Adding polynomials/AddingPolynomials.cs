using System;
using System.Collections.Generic;
using System.Linq;

class AddingPolynomials
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        int[] firstArray = new int[numberN];
        firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] secondArray = new int[numberN];
        secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] finalResult = new int[numberN];
        SumOfElements(firstArray, secondArray, finalResult);
        Console.WriteLine(string.Join(" ", finalResult));
    }
    static int[] SumOfElements(int[] firstArray, int[] secondArray, int[] finalResult)
    {

        for (int i = 0; i < firstArray.Length; i++)
        {
            finalResult[i] = firstArray[i] + secondArray[i];
        }
        return finalResult;
    }
}

