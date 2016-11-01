//Write a program that reads an integer N (which will always be less than 100 or equal) 
//and uses an expression to check if given N is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive

using System;

class PrimeChecking
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int divider = 2;

        while (divider < number || divider >= number)
        {
            if (number == 2)
            {
                Console.WriteLine("true");
                break;
            }

            else if (number % divider == 0 || number <= 1)
            {
                Console.WriteLine("false");
                break;
            }
            else
            {
                Console.WriteLine("true");
                break;
            }
            divider++;
        }

    }
}

