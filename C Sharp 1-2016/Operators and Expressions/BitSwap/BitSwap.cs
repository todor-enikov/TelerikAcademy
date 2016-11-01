//Write a program first reads 3 numbers n, p, q and k and than swaps bits {p, p+1, …, p+k-1}
//with bits {q, q+1, …, q+k-1} of n. Print the resulting integer on the console.
using System;

class BitSwap
{
    static void Main()
    {
        long numberN = long.Parse(Console.ReadLine());
        int numberP = int.Parse(Console.ReadLine());
        int numberQ = int.Parse(Console.ReadLine());
        int numberK = int.Parse(Console.ReadLine());
        for (int i = numberP; i <= numberP + numberK - 1; i++)
        {

            int mask = 1;
            long bitQ = (numberN & (mask << numberQ))>>numberQ;
            long bitP = (numberN & (mask << i))>>i;
            numberN = numberN & ~(mask << i);
            numberN = numberN & ~(mask << numberQ);
            numberN = numberN | (bitQ << i);
            numberN = numberN | (bitP << numberQ);
            numberQ++;
        }
        Console.WriteLine(numberN);

    }
}

