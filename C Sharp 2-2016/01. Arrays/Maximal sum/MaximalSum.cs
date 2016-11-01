using System;

class MaximalSum
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] arraySequence = new int[number];
        int currentSum = 0;
        int finalSum = 0;

        for (int i = 0; i < arraySequence.Length; i++)
        {
            arraySequence[i] = int.Parse(Console.ReadLine());
            currentSum += arraySequence[i];
            finalSum = Math.Max(currentSum, finalSum);

            if (currentSum <= 0)
            {
                currentSum = 0;
            }
        }
        Console.WriteLine(finalSum);
    }
}

