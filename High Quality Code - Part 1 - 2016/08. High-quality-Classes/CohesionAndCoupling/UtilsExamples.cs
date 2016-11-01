namespace CohesionAndCoupling
{
    using System;

    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(GetFile.GetFileExtension("example"));
            Console.WriteLine(GetFile.GetFileExtension("example.pdf"));
            Console.WriteLine(GetFile.GetFileExtension("example.new.pdf"));

            Console.WriteLine(GetFile.GetFileNameWithoutExtension("example"));
            Console.WriteLine(GetFile.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(GetFile.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                Calculation.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                Calculation.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Console.WriteLine("Volume = {0:f2}", Calculation.CalcVolume(3, 4, 5));
            Console.WriteLine("Diagonal XYZ = {0:f2}", Calculation.CalcDiagonalXYZ(3, 4, 5));
            Console.WriteLine("Diagonal XY = {0:f2}", Calculation.CalcDiagonalXY(3, 4));
            Console.WriteLine("Diagonal XZ = {0:f2}", Calculation.CalcDiagonalXZ(3, 5));
            Console.WriteLine("Diagonal YZ = {0:f2}", Calculation.CalcDiagonalYZ(4, 5));
        }
    }
}