//In combinatorics, the number of ways to choose N different members out of a group of N different elements 
//(also known as the number of combinations) is calculated by the following formula: formula For example, 
//there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. Your task is to write a program 
//that calculates N! / (K! * (N - K)!) for given N and K.
//    Try to use only two loops.

using System;
using System.Numerics;
class Calculate3
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int numberK = int.Parse(Console.ReadLine());
        BigInteger multiplyN = 1;
        BigInteger multiplyK = 1;
        BigInteger nMinusK = numberN - numberK;
        BigInteger multyplyNK = 1;

        for (int i = 1; i <= numberN; i++)
        {
            multiplyN *= i;
            if (i <= numberK)
            {
                multiplyK *= i;
            }
            if (i <= nMinusK)
            {
                multyplyNK *= i;
            }
        }
        Console.WriteLine(multiplyN / (multiplyK * multyplyNK));
    }
}

