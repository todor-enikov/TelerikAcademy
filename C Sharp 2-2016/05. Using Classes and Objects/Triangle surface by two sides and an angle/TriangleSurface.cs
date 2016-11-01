using System;

class TriangleSurface
{
    static void Main()
    {
        double lengthOfTheFirstSide = double.Parse(Console.ReadLine());
        double lengthOfTheSecondSide = double.Parse(Console.ReadLine());
        double angleBetweenTheSides = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F2}", SurfaceOfTriangle(lengthOfTheFirstSide, lengthOfTheSecondSide, angleBetweenTheSides));
    }
    static double SurfaceOfTriangle(double lengthOfTheFirstSide, double lengthOfTheSecondSide, double angleBetweenTheSides)
    {
        double radian = angleBetweenTheSides * Math.PI / 180;
        double sinAngle = Math.Sin(radian);
        double surface = (lengthOfTheFirstSide * lengthOfTheSecondSide * sinAngle) / 2;
        return surface;
    }
}

