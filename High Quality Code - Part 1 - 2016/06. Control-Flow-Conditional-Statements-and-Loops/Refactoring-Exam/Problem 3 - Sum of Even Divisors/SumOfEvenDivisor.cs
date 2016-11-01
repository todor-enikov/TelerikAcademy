using System;

public class SumOfEvenDivisor
{
    public static void Main()
    {
        long numberA = long.Parse(Console.ReadLine());
        long numberB = long.Parse(Console.ReadLine());
        long firstNumberSum = 0;

        do
        {
            for (int divisor = 1; divisor <= numberA; divisor++)
            {
                if (numberA % divisor == 0)
                {
                    if (divisor % 2 == 0)
                    {
                        firstNumberSum += divisor;
                    }
                }
            }

            numberA++;
        } while (numberA <= numberB);

        Console.WriteLine(firstNumberSum);
    }
}