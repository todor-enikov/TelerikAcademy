namespace Abstraction
{
    using System;
    using System.Text;
    using Abstraction_GoodAbstractionAndEncapsulation;

    public class Circle : IFigure
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
               return this.radius;
            }

            set
            {
                Validator.CheckIfDoubleIsEqualToZero(value);
                this.radius = value;
            }
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(string.Format("I am a circle. " + "My perimeter is {0:f2}. My surface is {1:f2}.", this.CalcPerimeter(), this.CalcSurface()));
            return result.ToString();
        }
    }
}