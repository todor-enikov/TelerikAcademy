using System;

class SelectionSort
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] arrayForSorting = new int[number];

        for (int i = 0; i < arrayForSorting.Length; i++)
        {
            arrayForSorting[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arrayForSorting.Length - 1; i++)
        {
            for (int j = i + 1; j < arrayForSorting.Length; j++)
            {
                if (arrayForSorting[i] > arrayForSorting[j]) // swap items
                {
                    int temp = arrayForSorting[i];
                    arrayForSorting[i] = arrayForSorting[j];
                    arrayForSorting[j] = temp;
                }
            }
        }

        for (int i = 0; i < arrayForSorting.Length; i++) // print sorted array
        {
            Console.WriteLine(arrayForSorting[i]);
        }
    }
}

