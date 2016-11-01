//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Don’t use arrays and the built-in sorting functionality.

using System;

class SortThreeNumbers
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.Write(firstNumber + " ");
            if (secondNumber > thirdNumber)
            {
                Console.Write(secondNumber + " " + thirdNumber);
            }
            else
            {
                Console.Write(thirdNumber + " " + secondNumber);
            }

        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            Console.Write(secondNumber + " ");
            if (firstNumber > thirdNumber)
            {
                Console.Write(firstNumber + " " + thirdNumber);
            }
            else
            {
                Console.Write(thirdNumber + " " + firstNumber);
            }

        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            Console.Write(thirdNumber + " ");
            if (firstNumber > secondNumber)
            {
                Console.Write(firstNumber + " " + secondNumber);
            }
            else
            {
                Console.Write(secondNumber + " " + firstNumber);
            }

        }
        else
        {
            Console.Write("{0} {1} {2}", firstNumber, secondNumber, thirdNumber);
        }

    }
}

