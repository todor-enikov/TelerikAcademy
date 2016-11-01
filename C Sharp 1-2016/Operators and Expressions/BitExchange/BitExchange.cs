//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer(read from the console).
using System;

class BitExchange
{
    static void Main()
    {
        uint numberN = uint.Parse(Console.ReadLine());
        uint mask = 7;
        uint bitsThirdFourthFifth = (numberN & (mask << 3)) >> 3;
        uint bitsTwentyFourthFifthSixth = (numberN & (mask << 24)) >> 24;
        numberN = numberN & ~(mask << 3);
        numberN = numberN & ~(mask << 24);
        numberN = numberN | (bitsThirdFourthFifth << 24);
        numberN = numberN | (bitsTwentyFourthFifthSixth << 3);
        Console.WriteLine(numberN);



        //  string convertToBits = Convert.ToString(numberN, 2);
        //  char[] bits = convertToBits.PadLeft(32, '0').ToCharArray();
        //  Array.Reverse(bits);
        //
        //  Console.WriteLine(bits);
        //  if (bits[3]==bits[24])
        //  {
        //      
        //  }

    }
}

