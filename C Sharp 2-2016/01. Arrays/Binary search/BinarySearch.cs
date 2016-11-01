using System;

class BinarySearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arraySequence = new int[n];

        for (int i = 0; i < arraySequence.Length; i++)
        {
            arraySequence[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arraySequence);

        int x = int.Parse(Console.ReadLine());

        int result = Array.BinarySearch(arraySequence, x);

        if (result < 0)
        {
            Console.WriteLine("-1");
        }
        else
        {
            Console.WriteLine(result);
        }

    }
}

