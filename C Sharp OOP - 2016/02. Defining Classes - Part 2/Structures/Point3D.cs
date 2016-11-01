using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public struct Point3D //task1
    {
        private static readonly Point3D start = new Point3D(0, 0, 0); //task2

        public Point3D(double x, double y, double z) //task1
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public static Point3D Start  //task2
        {
            get
            {
                return start;
            }
        }
        public override string ToString() //task1
        {
            return string.Format("The coordinates of the 3D point are: x: {0}, y: {1}, z: {2}", this.X, this.Y, this.Z);
        }
    }

}
