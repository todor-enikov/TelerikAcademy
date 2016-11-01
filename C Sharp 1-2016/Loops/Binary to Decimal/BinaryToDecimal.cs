//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        long decimalNumber = 0;
        int power = 1;
        for (int i = binaryNumber.Length-1; i >= 0; i--)
        {
            decimalNumber += (binaryNumber[i] - '0') * power;
            power *= 2;
        }
        Console.WriteLine(decimalNumber);
    }
}


