using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public class Path //task4
    {
        private List<Point3D> points;

        public Path()
        {
            this.points = new List<Point3D>();
        }

        public List<Point3D> Points { get; set; }

        public void AddPoints(Point3D point)
        {
            points.Add(point);
        }

        public void RemovePoints(int index)
        {
            points.RemoveAt(index);
        }
        
        public override string ToString()
        {
            return string.Join(" ", this.points);
        }     
    }
}
