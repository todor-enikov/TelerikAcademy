using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Structures
{
    public static class PathStorage //task4
    {
        public static void SaveToFile(List<Point3D> points)
        {
            string path = @"..\..\Points.txt";
            using (StreamWriter file = new StreamWriter(path, true))
            {
                foreach (var point in points)
                {
                    file.WriteLine(point.X+ " " + point.Y + " " + point.Z);
                }
            }
            Console.WriteLine("The points are saved!");
        }
        public static List<Point3D> ReadFromFile()
        {
            string path = @"..\..\Points.txt";
            List<Point3D> output = new List<Point3D>();

            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var coordinates = reader.ReadLine()
                        .Trim()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)                       
                        .ToArray();

                    Point3D pointToAdd = new Point3D(double.Parse(coordinates[0]), double.Parse(coordinates[1]), double.Parse(coordinates[2]));

                    output.Add(pointToAdd);
                }
            }
            Console.WriteLine("The file is readed!");
            return output;
        }
    }
}