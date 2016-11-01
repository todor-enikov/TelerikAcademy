//Write a program that reads 3 numbers:
//    integer a (0 <= a <= 500)
//    floating-point b
//    floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//    The number a should be printed in hexadecimal, left aligned
//    Then the number a should be printed in binary form, padded with zeroes
//    The number b should be printed with 2 digits after the decimal point, right aligned
//    The number c should be printed with 3 digits after the decimal point, left aligned.

using System;
using System.Threading;
using System.Globalization;
class FormatNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter integer a in the area 0 <= a <= 500: ");
        int a = int.Parse(Console.ReadLine());
        if (a > 0 || a < 500)
        {
            Console.WriteLine("You have to put number in the area between (0-500)");
            return;
        }
        Console.Write("Enter float b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter float c: ");
        float c = float.Parse(Console.ReadLine());
        string bin = Convert.ToString(a, 2).PadLeft(10, '0');
        Console.WriteLine("{0:X} | {1} | {2:0.00} | {3:0.000} |", a, bin, b, c);

    }
}

