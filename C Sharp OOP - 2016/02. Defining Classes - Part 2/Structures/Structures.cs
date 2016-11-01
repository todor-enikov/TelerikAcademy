using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public class Structures
    {
        public static void Main()
        {
            Point3D point = new Point3D(2, 3, 4);
            Point3D secondPoint = new Point3D(5, 4, 3);
            Console.WriteLine("The distance between the points is: {0}", StaticClass.CalculateDistance(point, secondPoint));
            Console.WriteLine(point.ToString());

            List<Point3D> allPoints = new List<Point3D>();
            allPoints.Add(point);
            allPoints.Add(secondPoint);
            PathStorage.SaveToFile(allPoints);
            PathStorage.ReadFromFile();

            Path finalPoint = new Path();
            finalPoint.AddPoints(point);
            finalPoint.AddPoints(secondPoint);
            Console.WriteLine(finalPoint.ToString());
        }
    }
}
