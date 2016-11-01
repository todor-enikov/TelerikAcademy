﻿using System;

class MergeSort
{
    static public void mergemethod(int[] numbers, int left, int mid, int right)
    {

        int[] temp = new int[25];
        int i, left_end, num_elements, tmp_pos;
        left_end = (mid - 1);
        tmp_pos = left;
        num_elements = (right - left + 1);

        while ((left <= left_end) && (mid <= right))
        {

            if (numbers[left] <= numbers[mid])
            {
                temp[tmp_pos++] = numbers[left++];
            }
            else
            {
                temp[tmp_pos++] = numbers[mid++];
            }


        }

        while (left <= left_end)
        {
            temp[tmp_pos++] = numbers[left++];
        }

        while (mid <= right)
        {
            temp[tmp_pos++] = numbers[mid++];
        }

        for (i = 0; i < num_elements; i++)
        {
            numbers[right] = temp[right];
            right--;
        }
    }

    static public void sortmethod(int[] numbers, int left, int right)
    {

        int mid;

        if (right > left)
        {
            mid = (right + left) / 2;
            sortmethod(numbers, left, mid);
            sortmethod(numbers, (mid + 1), right);
            mergemethod(numbers, left, (mid + 1), right);
        }

    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arraySequence = new int[n];

        for (int i = 0; i < arraySequence.Length; i++)
        {
            arraySequence[i] = int.Parse(Console.ReadLine());
        }

        sortmethod(arraySequence, 0, arraySequence.Length - 1);

        for (int i = 0; i < arraySequence.Length; i++)
        {
            Console.WriteLine(arraySequence[i]);
        }
    }
}

