//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecimalToHex
{
    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());
        long result = 0;
        string hexNumber = string.Empty;
        while (decimalNumber > 0)
        {
            result = decimalNumber % 16;

            switch (result)
            {
                case 10: hexNumber += 'A'; break;
                case 11: hexNumber += 'B'; break;
                case 12: hexNumber += 'C'; break;
                case 13: hexNumber += 'D'; break;
                case 14: hexNumber += 'E'; break;
                case 15: hexNumber += 'F'; break;
                default: hexNumber += result;
                    break;
            }

            decimalNumber = decimalNumber / 16;
        }
        char[] hexNumberArray = hexNumber.ToCharArray();
        Array.Reverse(hexNumberArray);
        Console.WriteLine(hexNumberArray);

    }
}

