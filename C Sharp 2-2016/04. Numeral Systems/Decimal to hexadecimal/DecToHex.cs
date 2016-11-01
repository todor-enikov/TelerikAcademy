using System;

class DecToHex
{
    static void Main()
    {
        long decNumber = long.Parse(Console.ReadLine());
        Console.WriteLine(DecimalToHexadecimal(decNumber));
    }
    static string DecimalToHexadecimal(long decNumber)
    {
        string hexNumber = "";
        while (decNumber != 0)
        {
            long digit = decNumber % 16;
            switch (digit)
            {
                case 10: hexNumber = 'A' + hexNumber;
                    break;
                case 11: hexNumber = 'B' + hexNumber;
                    break;
                case 12: hexNumber = 'C' + hexNumber;
                    break;
                case 13: hexNumber = 'D' + hexNumber;
                    break;
                case 14: hexNumber = 'E' + hexNumber;
                    break;
                case 15: hexNumber = 'F' + hexNumber;
                    break;
                default: hexNumber = digit + hexNumber;
                    break;
            }
            decNumber /= 16;
        }
        return hexNumber;
    }
}

