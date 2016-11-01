using System;

class MaximalKSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] arrayOfN = new int[n];
        int sum = 0;

        for (int i = 0; i < arrayOfN.Length; i++)
        {
            arrayOfN[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arrayOfN);
        Array.Reverse(arrayOfN);

        for (int i = 0; i < k; i++)
        {
            sum += arrayOfN[i];
        }
        Console.WriteLine(sum);

    }
}

