﻿using System;
using System.Collections.Generic;
using System.Linq;

class MergeSort2
{
    public static int[] MergeSort(int[] array)
    {
        // If list size is 0 (empty) or 1, consider it sorted and return it
        // (using less than or equal prevents infinite recursion for a zero length array).
        if (array.Length <= 1)
        {
            return array;
        }

        // Else list size is > 1, so split the list into two sublists.
        int middleIndex = (array.Length) / 2;
        int[] left = new int[middleIndex];
        int[] right = new int[array.Length - middleIndex];

        Array.Copy(array, left, middleIndex);
        Array.Copy(array, middleIndex, right, 0, right.Length);

        // Recursively call MergeSort() to further split each sublist
        // until sublist size is 1.
        left = MergeSort(left);
        right = MergeSort(right);

        // Merge the sublists returned from prior calls to MergeSort()
        // and return the resulting merged sublist.
        return Merge(left, right);
    }

    public static int[] Merge(int[] left, int[] right)
    {
        // Convert the input arrays to lists, which gives more flexibility 
        // and the option to resize the arrays dynamically.
        List<int> leftList = left.OfType<int>().ToList();
        List<int> rightList = right.OfType<int>().ToList();
        List<int> resultList = new List<int>();

        // While the sublist are not empty merge them repeatedly to produce new sublists 
        // until there is only 1 sublist remaining. This will be the sorted list.
        while (leftList.Count > 0 || rightList.Count > 0)
        {
            if (leftList.Count > 0 && rightList.Count > 0)
            {
                // Compare the 2 lists, append the smaller element to the result list
                // and remove it from the original list.
                if (leftList[0] <= rightList[0])
                {
                    resultList.Add(leftList[0]);
                    leftList.RemoveAt(0);
                }

                else
                {
                    resultList.Add(rightList[0]);
                    rightList.RemoveAt(0);
                }
            }

            else if (leftList.Count > 0)
            {
                resultList.Add(leftList[0]);
                leftList.RemoveAt(0);
            }

            else if (rightList.Count > 0)
            {
                resultList.Add(rightList[0]);
                rightList.RemoveAt(0);
            }
        }

        // Convert the resulting list back to a static array
        int[] result = resultList.ToArray();
        return result;
    }
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arraySequence = new int[n];

        for (int i = 0; i < arraySequence.Length; i++)
        {
            arraySequence[i] = int.Parse(Console.ReadLine());
        }

        arraySequence = MergeSort(arraySequence);

        for (int i = 0; i < arraySequence.Length; i++)
        {
            Console.WriteLine(arraySequence[i]);
        }
    }
}

