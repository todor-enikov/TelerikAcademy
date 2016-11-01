using System;
using System.Collections.Generic;
using System.Linq;

class NumberAsArray
{
    static void Main()
    {
        int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        List<int> firstArray = new List<int>();
        firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        List<int> secondArray = new List<int>();
        secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        List<int> result = new List<int>();

        if (firstArray.Count > secondArray.Count)
        {
            int numbersToAdd = firstArray.Count - secondArray.Count;
            for (int i = 0; i < numbersToAdd; i++)
            {
                secondArray.Add(0);
            }
        }
        else if (firstArray.Count < secondArray.Count)
        {
            int numbersToAdd = secondArray.Count - firstArray.Count;
            for (int i = 0; i < numbersToAdd; i++)
            {
                firstArray.Add(0);
            }
        }
        int plusOne = 0;

        for (int i = 0; i < firstArray.Count; i++)
        {

            int sum = firstArray[i] + secondArray[i] + plusOne;
            int finalResult = 0;
            plusOne = 0;
            if (sum > 9)
            {
                finalResult = sum % 10;
                plusOne++;
            }
            else
            {
                finalResult = sum;
            }
            result.Add(finalResult);
        }

        for (int i = 0; i < result.Count; i++)
        {
            if (i == result.Count)
            {
                Console.Write(result[i]);
            }
            else
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}