//Write a program that, for a given two integer numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;

class Calculate
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        double numberX = double.Parse(Console.ReadLine());
        double sum = 1;
        double multiply = 1;
        for (int i = 1; i <= numberN; i++)
        {
            multiply *= i;
            sum += (multiply / Math.Pow(numberX, i));
        }
        Console.WriteLine("{0:F5}", sum);

    }
}

