﻿//Write a program that enters a number N and after that enters more N numbers and calculates and prints their sum.
//Note: You may need to use a for-loop.

using System;

class SumOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("{0}", sum);
    }
}

