using System;
using System.Collections.Generic;
using System.Linq;

class TriangleSurface
{
    static void Main()
    {
        double lengthOfASide = double.Parse(Console.ReadLine());
        double altitudeToThatSide = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F2}", SurfaceOfTriangle(lengthOfASide, altitudeToThatSide));
    }

    static double SurfaceOfTriangle(double lengthOfASide, double altitudeToThatSide)
    {
        double surface = (lengthOfASide * altitudeToThatSide) / 2;
        return surface;
    }
}

