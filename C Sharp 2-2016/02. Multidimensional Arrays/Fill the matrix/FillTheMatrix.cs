using System;
using System.Collections.Generic;
using System.Linq;

class FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int counter = 1;

        switch (letter)
        {
            case 'a':
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[j, i] = counter++;
                    }
                }

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j == matrix.GetLength(1) - 1)
                        {
                            Console.Write(matrix[i, j]);
                        }
                        else
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                break;
            case 'b':
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (i % 2 == 0)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            matrix[j, i] = counter++;
                        }
                    }
                    else
                    {
                        for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                        {
                            matrix[j, i] = counter++;
                        }
                    }
                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j == matrix.GetLength(1) - 1)
                        {
                            Console.Write(matrix[i, j]);
                        }
                        else
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }

                break;
            case 'c':
                int secondcounter = 1;
                for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
                {
                    for (int j = 0; j < matrix.GetLength(0) - i; j++)
                    {
                        matrix[i + j, j] = secondcounter;
                    }
                    secondcounter *= 2;

                }
                for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                {
                    for (int j = 1; j < matrix.GetLength(1) - i; j++)
                    {
                        matrix[j - 1, j + i] = secondcounter;
                    }
                    secondcounter *= 2;

                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j == matrix.GetLength(1) - 1)
                        {
                            Console.Write(matrix[i, j]);
                        }
                        else
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                break;
            case 'd':
                string direction = "down";
                int row = 0;
                int col = 0;
                for (int i = 1; i <= n * n; i++)
                {

                    if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
                    {
                        row--;
                        col++;
                        direction = "right";
                    }
                    if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                    {
                        row++;
                        col--;
                        direction = "left";
                    }
                    if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
                    {
                        row--;
                        col--;
                        direction = "up";
                    }
                    if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                    {
                        row++;
                        col++;
                        direction = "down";
                    }


                    matrix[row, col] = i;

                    if (direction == "down")
                    {
                        row++;
                    }
                    if (direction == "up")
                    {
                        row--;
                    }
                    if (direction == "left")
                    {
                        col--;
                    }
                    if (direction == "right")
                    {
                        col++;
                    }
                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j == matrix.GetLength(1) - 1)
                        {
                            Console.Write(matrix[i, j]);
                        }
                        else
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }

                break;
            default: Console.WriteLine("Invalid Input!");
                break;
        }
    }
}

