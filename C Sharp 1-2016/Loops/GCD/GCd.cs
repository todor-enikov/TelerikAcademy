//Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.
//Use the Euclidean algorithm (find it in Internet).

using System;

class GCD
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split();
        int[] integerNumbers = Array.ConvertAll(numbers, int.Parse);

        while (integerNumbers[0] != 0 && integerNumbers[1] != 0)
        {
            if (integerNumbers[0] > integerNumbers[1])
            {
                integerNumbers[0] %= integerNumbers[1];
            }
            else if (integerNumbers[0] < integerNumbers[1])
            {
                integerNumbers[1] %= integerNumbers[0];
            }
        }

        if (integerNumbers[0] == 0)
        {
            Console.WriteLine(integerNumbers[1]);
        }
        else
        {
            Console.WriteLine(integerNumbers[0]);
        }

    }
}

