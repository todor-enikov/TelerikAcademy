using System;

class Compare
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n];
        int[] secondArray = new int[n];
        int firstCounter = 0;
        int secondCounter = 0;

        for (int i = 0; i <= firstArray.Length - 1; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i <= secondArray.Length - 1; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i <= firstArray.Length - 1; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                firstCounter++;
            }
            else
            {
                secondCounter++;
            }
        }
        if (firstCounter == n && secondCounter == 0)
        {
            Console.WriteLine("Equal");
        }
        else if (firstCounter != n && secondCounter > 0)
        {
            Console.WriteLine("Not equal");
        }
    }
}

