using System;
using System.Collections.Generic;
using System.Linq;

class IntegerCalculation
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(Minimum(numbers));
        Console.WriteLine(Maximum(numbers));
        Console.WriteLine("{0:F2}", Average(numbers));
        Console.WriteLine(Sum(numbers));
        Console.WriteLine(Product(numbers));
    }

    static int Minimum(int[] numbers)
    {
        return numbers.Min();
    }

    static int Maximum(int[] numbers)
    {
        return numbers.Max();
    }

    static double Average(int[] numbers)
    {
        List<int> list = numbers.ToList();
        return list.Average();
    }

    static int Sum(int[] numbers)
    {
        return numbers.Sum();
    }

    static long Product(int[] numbers)
    {
        long product = 1;
        foreach (int element in numbers)
        {
            product *= element;
        }
        return product;
    }
}
//My solution.

//using System;
//using System.Collections.Generic;
//using System.Linq;
//
//class IntegerCalculation
//{
//    static void Main()
//    {
//        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//
//        Console.WriteLine(Minimum(numbers));
//        Console.WriteLine(Maximum(numbers));
//        Console.WriteLine("{0:F2}", Average(numbers));
//        Console.WriteLine(Sum(numbers));
//        Console.WriteLine(Product(numbers));
//    }
//
//    static int Minimum(int[] numbers)
//    {
//        int minNumber = int.MaxValue;
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            if (i == 0)
//            {
//                minNumber = numbers[i];
//            }
//            if (numbers[i] < minNumber)
//            {
//                minNumber = numbers[i];
//            }
//
//        }
//        return minNumber;
//    }
//
//    static int Maximum(int[] numbers)
//    {
//        int maxNumber = int.MaxValue;
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            if (i == 0)
//            {
//                maxNumber = numbers[i];
//            }
//            if (numbers[i] > maxNumber)
//            {
//                maxNumber = numbers[i];
//            }
//
//        }
//        return maxNumber;
//    }
//
//    static double Average(int[] numbers)
//    {
//        double average = (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4]) / 5.0;
//        return average;
//    }
//
//    static int Sum(int[] numbers)
//    {
//        int sum = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4];
//        return sum;
//    }
//
//    static long Product(int[] numbers)
//    {
//        long product = 1;
//        foreach (int element in numbers)
//        {
//            product *= element;
//        }
//        return product;
//    }
//}