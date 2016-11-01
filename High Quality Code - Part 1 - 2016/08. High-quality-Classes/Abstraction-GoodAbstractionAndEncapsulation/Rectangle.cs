namespace Abstraction
{
    using System;
    using System.Text;
    using Abstraction_GoodAbstractionAndEncapsulation;

    public class Rectangle : IFigure
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                Validator.CheckIfDoubleIsEqualToZero(value);
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                Validator.CheckIfDoubleIsEqualToZero(value);
                this.height = value;
            }
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(string.Format("I am a rectangle. " + "My perimeter is {0:f2}. My surface is {1:f2}.", this.CalcPerimeter(), this.CalcSurface()));
            return result.ToString();
        }
    }
}