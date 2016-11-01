using System;

class BinToHex
{
    static void Main()
    {
        string binNumber = Console.ReadLine();
        Console.WriteLine(BinaryToHexadecimal(binNumber));
    }
    private static string BinaryToHexadecimal(string number)
    {
        // Binary to decimal
        long numberInDecimal = Convert.ToInt64(number, 2);

        // Decimal to hex
        string numberInHex = Convert.ToString(numberInDecimal, 16);

        return numberInHex.ToUpper().TrimStart('0');
    }
}

