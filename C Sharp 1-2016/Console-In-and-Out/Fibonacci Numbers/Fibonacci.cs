//Write a program that reads a number N and prints on the console the first N members of the Fibonacci 
//sequence (at a single line, separated by comma and space - ", ") : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
using System;
class Fibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long firstNumber = 0;
        long secondNumber = 1;
        long thirdNumber = 0;
        if (n > 1)
        {
            Console.Write(firstNumber + ", " + secondNumber);
            for (int i = 2; i < n; i++)
            {
                thirdNumber = firstNumber + secondNumber;
                Console.Write(", " + thirdNumber);
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }
        }
        else
        {
            Console.WriteLine(0);
        }

    }
}

