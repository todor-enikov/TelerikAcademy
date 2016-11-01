//Write a program that reads from the console a positive integer number N and prints a matrix like in 
//the examples below. Use two nested loops.
//Challenge: achieve the same effect without nested loops

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            int counter = i;
            for (int j = 0; j < number; j++)
            {
                Console.Write("{0} ", counter);
                counter++;
            }
            Console.WriteLine("");
        }
    }
}

