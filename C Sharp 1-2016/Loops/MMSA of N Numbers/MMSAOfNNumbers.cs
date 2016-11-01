//Write a program that reads from the console a sequence of N integer numbers and returns the minimal,
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//    The input starts by the number N (alone in a line) followed by N lines, each holding an integer number.
//    The output is like in the examples below.

using System;
class MMSAOfNNumbers
{
    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());
        double sum = 0;
        double maxNumber = 0;
        double minNumber = 0;
        for (int i = 0; i < numbersCount; i++)
        {
            double number = double.Parse(Console.ReadLine());
            if (i == 0)
            {
                minNumber = number;
                maxNumber = number;
            }
            if (number < minNumber)
            {
                minNumber = number;
            }
            if (number > maxNumber)
            {
                maxNumber = number;
            }
            sum += number;
        }
        double average = sum / numbersCount;
        Console.WriteLine("min={0:0.00}", minNumber);
        Console.WriteLine("max={0:0.00}", maxNumber);
        Console.WriteLine("sum={0:0.00}", sum);
        Console.WriteLine("avg={0:0.00}", average);
    }
}

