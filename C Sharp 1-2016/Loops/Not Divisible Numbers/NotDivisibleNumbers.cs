//Write a program that reads from the console a positive integer N and prints all the numbers 
//from 1 to N not divisible by 3 or 7, on a single line, separated by a space.
using System;
class NotDivisibleNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            if (i%3==0 || i%7==0)
            {
                continue;
            }
            Console.Write(i + " ");
        }
    }
}

