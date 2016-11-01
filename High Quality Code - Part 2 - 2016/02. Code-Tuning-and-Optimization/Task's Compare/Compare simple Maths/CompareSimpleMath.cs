namespace Compare_simple_Maths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CompareSimpleMath
    {
        public static void Main()
        {
            CompareSimpleMath.AddResults(5);
            CompareSimpleMath.SubtractResults(5);
            CompareSimpleMath.MultiplyResults(5);
            CompareSimpleMath.DivideResults(5);
            CompareSimpleMath.IncrementResults(5);
        }

        public static void AddResults(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();

                //You can change here some other type of variable etc int, double, float, decimal or long.
                decimal sum = 0;
                for (int j = 0; j < 100000000; j++)
                {
                    sum += j;
                }

                stopwatch.Stop();
                Console.WriteLine("The elapsed time for add is: {0}", stopwatch.Elapsed);
            }
        }

        public static void SubtractResults(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();

                //You can change here some other type of variable etc int, double, float, decimal or long.
                long sum = 100000000;
                for (int j = 0; j < 100000000; j++)
                {
                    sum -= j;
                }

                stopwatch.Stop();
                Console.WriteLine("The elapsed time for subtract is: {0}", stopwatch.Elapsed);
            }
        }

        public static void MultiplyResults(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();

                //You can change here some other type of variable etc int, double, float, decimal or long.
                int sum = 1;
                for (int j = 0; j < 100000000; j++)
                {
                    sum *= j;
                }

                stopwatch.Stop();
                Console.WriteLine("The elapsed time for multiply is: {0}", stopwatch.Elapsed);
            }
        }

        public static void DivideResults(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();

                //You can change here some other type of variable etc int, double, float, decimal or long.
                double sum = 1;
                for (int j = 1; j < 100000000; j++)
                {
                    sum /= j;
                }

                stopwatch.Stop();
                Console.WriteLine("The elapsed time for divide is: {0}", stopwatch.Elapsed);
            }
        }

        public static void IncrementResults(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();

                //You can change here some other type of variable etc int, double, float, decimal or long.
                float counter = 0;
                for (int j = 1; j < 100000000; j++)
                {
                    counter++;
                }

                stopwatch.Stop();
                Console.WriteLine("The elapsed time for increment is: {0}", stopwatch.Elapsed);
            }
        }
    }
}
