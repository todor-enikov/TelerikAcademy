using System;

class Allocate
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i <= array.Length - 1; i++)
        {
            array[i] = i * 5;
            Console.WriteLine(array[i]);
        }
    }
}

