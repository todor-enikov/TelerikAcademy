//Write a program that reads from the console the radius r of a circle and prints its 
//perimeter and area, rounded and formatted with 2 digits after the decimal point.
using System;

class CirclePerimeterArea
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;
        Console.WriteLine("{0:F2} {1:F2}", perimeter, area);
    }
}

