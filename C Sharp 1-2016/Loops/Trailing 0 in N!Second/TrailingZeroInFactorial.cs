//Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
//Your program should work well for very big numbers, e.g. N = 100000.
using System;

class TrailingZeroInFactorial
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int countZeros = 0;
        while (numberN > 0)
        {
            countZeros += numberN / 5;
            numberN /= 5;
        }
        Console.WriteLine(countZeros);
    }
}

