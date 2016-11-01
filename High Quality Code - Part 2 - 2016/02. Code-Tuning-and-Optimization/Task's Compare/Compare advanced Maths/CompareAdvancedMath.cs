namespace Compare_advanced_Maths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CompareAdvancedMath
    {
        public static void Main()
        {
            CompareAdvancedMath.SquareRootResults(5);
            CompareAdvancedMath.NaturalLogarithmResults(5);
            CompareAdvancedMath.SinusResults(5);
        }

        public static void SquareRootResults(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();

                //You can change here some other type of variable etc double, float or decimal.
                //Double is fastest.
                for (double j = 0; j < 100000000; j++)
                {
                    Math.Sqrt(j);
                }

                stopwatch.Stop();
                Console.WriteLine("The elapsed time for square root is: {0}", stopwatch.Elapsed);
            }
        }

        public static void NaturalLogarithmResults(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();

                //You can change here some other type of variable etc double, float or decimal.
                //Double is fastest.
                for (double j = 0; j < 100000000; j++)
                {
                    Math.Log(j);
                }

                stopwatch.Stop();
                Console.WriteLine("The elapsed time for natural logarithm is: {0}", stopwatch.Elapsed);
            }
        }

        public static void SinusResults(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();

                //You can change here some other type of variable etc double, float or decimal.
                //Double is fastest.
                for (decimal j = 0; j < 10000000; j++)
                {
                    Math.Sin((double)j);
                }

                stopwatch.Stop();
                Console.WriteLine("The elapsed time for sinus is: {0}", stopwatch.Elapsed);
            }
        }
    }
}
