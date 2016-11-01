//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecimalToBinary
{
    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());
        long result = 0;
        string binaryNumber = string.Empty;
        while (decimalNumber > 0)
        {
            result = decimalNumber % 2;
            decimalNumber = decimalNumber / 2;
            binaryNumber += result.ToString();
        }
        char[] reverseNumber = binaryNumber.ToCharArray();
        Array.Reverse(reverseNumber);
        Console.WriteLine(reverseNumber);
    }
}

