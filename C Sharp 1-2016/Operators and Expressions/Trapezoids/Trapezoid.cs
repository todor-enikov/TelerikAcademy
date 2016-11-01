//Write an expression that calculates trapezoid's area by given sides a and b and height h. The three values
//should be read from the console in the order shown below. All three value will be floating-point numbers.
using System;

class Trapezoid
{
    static void Main()
    {
        float baseA = float.Parse(Console.ReadLine());
        float baseB = float.Parse(Console.ReadLine());
        float height = float.Parse(Console.ReadLine());
        float areaOfTrapecoid = 0.5f * (baseA + baseB) * height;
        Console.WriteLine("{0:F7}", areaOfTrapecoid);
    }
}

