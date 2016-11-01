//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and 
//solves it (prints its real roots).
using System;
class Quadratic
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("The equation isn't quadric!");
        }

        double determinant = Math.Sqrt(b * b - 4 * a * c);
        if (determinant == 0)
        {
            Console.WriteLine("{0:0.00}", -b / (2.0 * a));
        }
        else if (determinant > 0)
        {
            Console.WriteLine("{0:0.00}\n{1:0.00}", (-b - determinant) / (2.0 * a), (-b + determinant) / (2.0 * a));
        }
        else
        {
            Console.WriteLine("no real roots");
        }

    }
}

