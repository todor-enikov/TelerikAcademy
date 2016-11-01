using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int numberN = int.Parse(input[0]);
        int numberM = int.Parse(input[1]);
        int[,] matrix = new int[numberN, numberM];

        for (int row = 0; row < numberN; row++)
        {
            string[] elements = Console.ReadLine().Split(' ');

            for (int col = 0; col < numberM; col++)
            {
                matrix[row, col] = int.Parse(elements[col]);
            }
        }

        long maximalSum = long.MinValue;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                long sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +

                           matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +

                           matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > maximalSum)
                {
                    maximalSum = sum;
                }
            }
        }
        Console.WriteLine(maximalSum);
    }
}

