using System;

class NthBit
{
    static void Main()
    {
        int numberP = int.Parse(Console.ReadLine());
        int indexN = int.Parse(Console.ReadLine());
        int mask = 1 << indexN;
        int nAndMask = mask & numberP;
        int bit = nAndMask >> indexN;
        Console.WriteLine("{0}", bit);
    }
}

