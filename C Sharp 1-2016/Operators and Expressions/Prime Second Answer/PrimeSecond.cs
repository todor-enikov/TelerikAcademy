//Write a program that reads an integer N (which will always be less than 100 or equal) 
//and uses an expression to check if given N is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive
using System;

class PrimeSecond
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int divider = 2;
        bool isPrime = true;
        if (number<=1)
        {
            isPrime = false;
        }
        while (divider < number)
        {
            if (number % divider == 0)
            {
                isPrime = false;
                break;
            }
            divider++;
        }
        Console.WriteLine((isPrime).ToString().ToLower());
    }
}

