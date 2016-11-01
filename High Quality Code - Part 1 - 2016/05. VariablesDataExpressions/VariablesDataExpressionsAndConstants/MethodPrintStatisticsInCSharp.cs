namespace VariablesDataExpressionsAndConstants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MethodPrintStatisticsInCSharp
    {
        public static void Main()
        {
            double[] array = { 1, 2, 3, 4, 5 };
            int counter = 5;
            MethodPrintStatisticsInCSharp.PrintStatistics(array, counter);
        }

        public static void PrintStatistics(double[] elements, int count)
        {
            double maxElement = 0;
            for (int i = 0; i < count; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }

            PrintTheMaximumElement(maxElement);

            double minElement = elements[0];
            for (int i = 0; i < count; i++)
            {
                if (elements[i] < minElement)
                {
                    minElement = elements[i];
                }
            }

            PrintTheMinimumElement(minElement);

            double value = 0;
            for (int i = 0; i < count; i++)
            {
                value += elements[i];
            }

            double average = value / count;
            PrintAverage(average);
        }

        public static void PrintAverage(double average)
        {
            Console.WriteLine("The average in the array is: {0}", average);
        }

        private static void PrintTheMinimumElement(double minElement)
        {
            Console.WriteLine("The minimum element in the array is: {0}", minElement);
        }

        private static void PrintTheMaximumElement(double maxElement)
        {
            Console.WriteLine("The maximum element in the array is: {0}", maxElement);
        }
    }
}
