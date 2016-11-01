//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the Nth Catalan number by given N

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        BigInteger twoMultiplyN = 1;
        BigInteger nPlusOne = 1;
        BigInteger nFactorial = 1;
        for (int i = 1; i <= 2 * numberN; i++)
        {
            twoMultiplyN *= i;
            if (i <= numberN + 1)
            {
                nPlusOne *= i;
            }
            if (i <= numberN)
            {
                nFactorial *= i;
            }
        }
        Console.WriteLine(twoMultiplyN / (nPlusOne * nFactorial));
    }
}

