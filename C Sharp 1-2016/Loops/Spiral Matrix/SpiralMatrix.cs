//Write a program that reads from the console a positive integer number N (1 ≤ N ≤ 20) and prints a matrix 
//holding the numbers from 1 to N*N in the form of square spiral like in the examples below.
using System;

class SpiralMatrix
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[,] matrix = new int[numberN, numberN];
        int row = 0;
        int col = 0;
        string direction = "right";
        for (int i = 1; i <= numberN * numberN; i++)
        {
            if (direction == "right" && (col > numberN - 1 || matrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;

            }
            if (direction == "down" && (row > numberN - 1 || matrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }
            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }
            if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            {
                direction = "right";
                row++;
                col++;
            }
            matrix[row, col] = i;

            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }
        for (row = 0; row < numberN; row++)
        {
            for (col = 0; col < numberN; col++)
            {
                if (matrix[row, col] < 10)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                else
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
            }
            Console.WriteLine();
        }
    }
}

