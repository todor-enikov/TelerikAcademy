﻿//We are given an integer number N(read from the console), a bit value v(read from the console as well)
//(v = 0 or 1) and a position P(read from the console). Write a sequence of operators (a few lines of C# code)
//that modifies N to hold the value v at the position P from the binary representation of N while preserving all 
//other bits in N. Print the resulting number on the console.
using System;

class ModifyBit
{
    static void Main()
    {
        ulong numberN = ulong.Parse(Console.ReadLine());
        int indexP = int.Parse(Console.ReadLine());
        int bitNumberV = int.Parse(Console.ReadLine());
        ulong result;
        ulong mask;
        if (bitNumberV == 1)
        {
            mask = (ulong)1 << indexP;
            result = numberN | mask;
        }
        else
        {
            mask = (ulong)~(1 << indexP);
            result = numberN & mask;
        }

        Console.WriteLine("{0}", result);
    }
}

