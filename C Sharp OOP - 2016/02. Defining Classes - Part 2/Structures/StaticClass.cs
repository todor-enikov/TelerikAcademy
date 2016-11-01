using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public static class StaticClass
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double deltaX = secondPoint.X - firstPoint.X;
            double deltaY = secondPoint.Y - firstPoint.Y;
            double deltaZ = secondPoint.Z - firstPoint.Z;

            double distance = (double)Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
            return distance;
        }
    }
}
