using System;

class BinToDec
{
    static void Main()
    {
        string binNumber = Console.ReadLine();
        Console.WriteLine(BinaryToDecimal(binNumber));
    }
    static long BinaryToDecimal(string binNumber)
    {
        long sum = 0;
        foreach (char bit in binNumber)
        {
            sum = (bit - '0') + sum * 2;
        }
        return sum;
    }
}

