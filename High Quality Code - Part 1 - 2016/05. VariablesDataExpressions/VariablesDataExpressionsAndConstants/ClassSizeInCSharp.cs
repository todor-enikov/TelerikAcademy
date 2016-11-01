namespace VariablesDataExpressionsAndConstants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ClassSizeInCSharp
    {
        private double width;
        private double height;

        public ClassSizeInCSharp(double width, double height)
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
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("The width cannot be less or equal to zero!");
                }

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
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("The height cannot be less or equal to zero!");
                }

                this.height = value;
            }
        }

        public static ClassSizeInCSharp GetRotatedSize(ClassSizeInCSharp size, double angleOfTheFigure)
        {
            double widthOfTheFigure = size.Width;
            double heightOfTheFigure = size.Height;
            double cosine = Math.Abs(Math.Cos(angleOfTheFigure));
            double sinus = Math.Abs(Math.Sin(angleOfTheFigure));
            var result = new ClassSizeInCSharp(
                                              (cosine * widthOfTheFigure) + (sinus * heightOfTheFigure),
                                              (sinus * widthOfTheFigure) + (cosine * heightOfTheFigure));
            return result;
        }
    }
}
