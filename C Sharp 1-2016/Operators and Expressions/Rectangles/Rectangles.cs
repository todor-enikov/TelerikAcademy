//Write an expression that calculates rectangle’s perimeter and area by given width and height. 
//The width and height should be read from the console.
using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter widht on the reactangle.");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height on the reactangle.");
        double height = double.Parse(Console.ReadLine());
        double perimeter = 2f * width + 2 * height;
        double area = 1f * width * height;
        Console.WriteLine("{0:0.00} {1:0.00}", area, perimeter);
    }
}

