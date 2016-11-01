using System;
using System.Collections.Generic;
using System.Text;

class HexToBin
{
    static void Main()
    {
        string hexNumber = Console.ReadLine();
        Console.WriteLine(HexadecimalToBinary(hexNumber));
    }
    public static Dictionary<char, string> HexToBinaryTable = new Dictionary<char, string>()
        {
            {'0',"0000" },
            {'1',"0001" },
            {'2',"0010" },
            {'3',"0011" },
            {'4',"0100" },
            {'5',"0101" },
            {'6',"0110" },
            {'7',"0111" },
            {'8',"1000" },
            {'9',"1001" },
            {'A',"1010" },
            {'B',"1011" },
            {'C',"1100" },
            {'D',"1101" },
            {'E',"1110" },
            {'F',"1111" }
        };
    private static string HexadecimalToBinary(string hexNumber)
    {
        StringBuilder decimalRepresentation = new StringBuilder();

        foreach (var digit in hexNumber)
        {
            decimalRepresentation.Append(HexToBinaryTable[digit]);
        }

        return (decimalRepresentation.ToString().Substring(decimalRepresentation.ToString().IndexOf('1'), decimalRepresentation.ToString().Length - decimalRepresentation.ToString().IndexOf('1')));
    }
}

