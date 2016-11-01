// You are given N integers (given in a single line, separated by a space).
// Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
// Elements are counted from 1 to N, so the first element is odd, the second is even, etc.

using System;

class OddEvenProduct
{
    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());
        string[] numbers = Console.ReadLine().Split();
        double oddProduct = 1;
        double evenProduct = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddProduct *= Convert.ToInt32(numbers[i]);
            }
            else if (i % 2 != 0)
            {
                evenProduct *= Convert.ToInt32(numbers[i]);
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes {0}", oddProduct);
        }
        else if (oddProduct != evenProduct)
        {
            Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
        }
    }
}

