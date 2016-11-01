using System;

class TriangleSurface
{
    static void Main()
    {
        double lengthOfTheFirstSide = double.Parse(Console.ReadLine());
        double lengthOfTheSecondSide = double.Parse(Console.ReadLine());
        double lengthOfThethirthSide = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F2}", SurfaceOfTriangle(lengthOfTheFirstSide, lengthOfTheSecondSide, lengthOfThethirthSide));

    }
    static double SurfaceOfTriangle(double lengthOfTheFirstSide, double lengthOfTheSecondSide, double lengthOfThethirthSide)
    {
        double halfPerimeter = (lengthOfTheFirstSide + lengthOfTheSecondSide + lengthOfThethirthSide) / 2;
        double surface = halfPerimeter * (halfPerimeter - lengthOfTheFirstSide) * (halfPerimeter - lengthOfTheSecondSide) * (halfPerimeter - lengthOfThethirthSide);

        return Math.Sqrt(surface);
    }
}

