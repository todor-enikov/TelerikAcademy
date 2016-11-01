//Write a program that calculates N! / K! for given N and K.
//Use only one loop.

using System;
using System.Numerics;
class CalculateAgain
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int numberK = int.Parse(Console.ReadLine());
        BigInteger multiplicationN = 1;
        BigInteger multiplicationK = 1;
        for (int i = 1; i <= numberN; i++)
        {
            multiplicationN *= i;
            if (i<=numberK)
            {
                multiplicationK *= i;
            }
        }
        Console.WriteLine(multiplicationN / multiplicationK);
    }
}

