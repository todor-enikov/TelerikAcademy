﻿using System;

class EnglishDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Digit(number));
    }
    static string Digit(int number)
    {
        int lastDigit = number % 10;
        string digitAsWord = null;
        switch (lastDigit)
        {
            case 1: digitAsWord = "one";
                break;
            case 2: digitAsWord = "two";
                break;
            case 3: digitAsWord = "three";
                break;
            case 4: digitAsWord = "four";
                break;
            case 5: digitAsWord = "five";
                break;
            case 6: digitAsWord = "six";
                break;
            case 7: digitAsWord = "seven";
                break;
            case 8: digitAsWord = "eight";
                break;
            case 9: digitAsWord = "nine";
                break;
            default: digitAsWord = "zero";
                break;
        }
        return digitAsWord;
    }
}

