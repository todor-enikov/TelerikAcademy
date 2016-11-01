//Write a program that finds the biggest of three numbers that are read from the console.
using System;

class BiggestOfThreeNumbers
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine("{0}", firstNumber);
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine("{0}", secondNumber);
        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            Console.WriteLine("{0}", thirdNumber);
        }
        else if (firstNumber == secondNumber && firstNumber == thirdNumber && secondNumber == thirdNumber)
        {
            Console.WriteLine("{0}", firstNumber);
        }

    }
}

