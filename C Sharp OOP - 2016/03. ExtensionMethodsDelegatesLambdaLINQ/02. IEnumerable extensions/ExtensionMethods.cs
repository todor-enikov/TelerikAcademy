using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_extensions
{
    public static class ExtensionMethods
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            CheckIfEmptyCollection(collection);

            T sum = (dynamic)0;
            foreach (var item in collection)
            {
                sum += (dynamic)item;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            CheckIfEmptyCollection(collection);

            T product = (dynamic)1;
            foreach (var item in collection)
            {
                product *= (dynamic)item;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            CheckIfEmptyCollection(collection);

            T min = collection.First();
            foreach (var item in collection)
            {
                if (item.CompareTo(min) == -1)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
        {
            CheckIfEmptyCollection(collection);

            T max = collection.First();
            foreach (var item in collection)
            {
                if ((dynamic)item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        public static double Average<T>(this IEnumerable<T> collection)
        {
            CheckIfEmptyCollection(collection);

            T sum = collection.Sum();
            var count = collection.Count();
            double average = (dynamic)sum / (double)count;
            return average;
        }

        public static void CheckIfEmptyCollection<T>(IEnumerable<T> collection)
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection is empty!");
            }
        }
    }
}
