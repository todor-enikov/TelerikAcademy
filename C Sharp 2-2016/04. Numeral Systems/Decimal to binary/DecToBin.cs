using System;

class DecToBin
{
    static void Main()
    {
        long decNumber = long.Parse(Console.ReadLine());
        Console.WriteLine(DecimalToBinary(decNumber));
    }

    static string DecimalToBinary(long decNumber)
    {
        string binNumber = "";
        while (decNumber != 0)
        {
            long digit = decNumber % 2;
            binNumber = digit + binNumber;
            decNumber /= 2;
        }
        return binNumber;
    }
}

