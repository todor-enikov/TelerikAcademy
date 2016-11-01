using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ShapeMain
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Triangle(5, 5));
            shapes.Add(new Triangle(7, 3));
            shapes.Add(new Rectangle(4, 5));
            shapes.Add(new Rectangle(3, 6));
            shapes.Add(new Square(5));
            shapes.Add(new Square(3));

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
