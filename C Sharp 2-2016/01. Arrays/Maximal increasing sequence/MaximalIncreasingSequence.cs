using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] array = new int[number];
        int firstCounter = 1;
        int secondCounter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] < array[i])
            {
                firstCounter++;
                secondCounter = Math.Max(firstCounter, secondCounter);
            }
            else
            {
                firstCounter = 1;
            }
        }
        Console.WriteLine(secondCounter);
    }
}

