using System;

public class MutantSquirrels
{
    public static void Main()
    {
        long trees = long.Parse(Console.ReadLine());
        long branches = long.Parse(Console.ReadLine());
        long squirrels = long.Parse(Console.ReadLine());
        long numberOfTails = long.Parse(Console.ReadLine());
        double result = trees * branches * squirrels * numberOfTails;
        if (result % 2 == 0)
        {
            result *= 376439;
        }
        else
        {
            result = result / 7.0;
        }

        Console.WriteLine("{0:F3}", result);
    }
}