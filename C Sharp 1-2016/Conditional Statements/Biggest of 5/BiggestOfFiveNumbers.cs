﻿//Write a program that finds the biggest of 5 numbers that are read from the console, using only 5 if statements.
using System;

class BiggestOfFiveNumbers
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        double fourthNumber = double.Parse(Console.ReadLine());
        double fifthNumber = double.Parse(Console.ReadLine());
        if (firstNumber > secondNumber && firstNumber > thirdNumber & firstNumber > fourthNumber && firstNumber > fifthNumber)
        {
            Console.WriteLine(firstNumber);
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber && secondNumber > fourthNumber && secondNumber > fifthNumber)
        {
            Console.WriteLine(secondNumber);
        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber && thirdNumber > fourthNumber && thirdNumber > fifthNumber)
        {
            Console.WriteLine(thirdNumber);
        }
        else if (fourthNumber > fifthNumber && fourthNumber > secondNumber && fourthNumber > thirdNumber && fourthNumber > fifthNumber)
        {
            Console.WriteLine(fourthNumber);
        }
        else if (fifthNumber > firstNumber && fifthNumber > secondNumber && fifthNumber > thirdNumber && fifthNumber > fourthNumber)
        {
            Console.WriteLine(fifthNumber);
        }
        else
        {
            Console.WriteLine(firstNumber);
        }
    }
}

