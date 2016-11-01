//Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
//Your program should work well for very big numbers, e.g. N = 100000.

using System;
using System.Numerics;
class TrailingZeroInFactorial
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        BigInteger sum = 1;
        int countZeros = 0;
        for (int i = 1; i <= numberN; i++)
        {
            sum *= i;
        }
        string finalSum = sum.ToString();
        for (int i = finalSum.Length - 1; i >= 0; i--)
        {
            if (finalSum[i] == '0')
            {
                while (finalSum[i] == '0')
                {
                    countZeros++;
                    break;
                }
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(countZeros);
    }
}

