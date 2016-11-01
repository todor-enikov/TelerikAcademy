//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality.

using System;
class HexToDecimal
{
    static void Main()
    {
        string hexNumber = Console.ReadLine();
        long decimalNumber = 0;
        long power = 1;
        for (int i = hexNumber.Length - 1; i >= 0; i--)
        {
            switch (hexNumber[i])
            {
                case 'A': decimalNumber += 10 * power; break;
                case 'B': decimalNumber += 11 * power; break;
                case 'C': decimalNumber += 12 * power; break;
                case 'D': decimalNumber += 13 * power; break;
                case 'E': decimalNumber += 14 * power; break;
                case 'F': decimalNumber += 15 * power; break;
                default: decimalNumber += (hexNumber[i] - '0') * power; break;
            }
            power *= 16;
        }
        Console.WriteLine(decimalNumber);
    }
}

