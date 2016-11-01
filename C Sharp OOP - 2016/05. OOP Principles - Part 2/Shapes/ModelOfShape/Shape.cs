using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The width can't be less than zero or equal to it!");
                }
                width = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The height can't be less than zero or equal to it!");
                }
                height = value;
            }
        }

        public abstract double CalculateSurface();

    }
}
