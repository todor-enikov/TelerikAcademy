//Write a program that gets two numbers from the console and prints the greater of them.
using System;
class ComparingTwoNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double result = Math.Max(a, b);
        Console.WriteLine(result);
    }
}

