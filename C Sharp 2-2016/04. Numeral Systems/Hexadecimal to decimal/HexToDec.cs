using System;

class HexToDec
{
    static void Main(string[] args)
    {
        string hexNumber = Console.ReadLine();
        Console.WriteLine(HexadecimalToDecimal(hexNumber));
    }
    static long HexadecimalToDecimal(string hexNumber)
    {
        long decNumber = 0;
        foreach (char symbol in hexNumber)
        {
            switch (symbol)
            {
                case 'A': decNumber = 10 + decNumber * 16;
                    break;
                case 'B': decNumber = 11 + decNumber * 16;
                    break;
                case 'C': decNumber = 12 + decNumber * 16;
                    break;
                case 'D': decNumber = 13 + decNumber * 16;
                    break;
                case 'E': decNumber = 14 + decNumber * 16;
                    break;
                case 'F': decNumber = 15 + decNumber * 16;
                    break;
                default: decNumber = (symbol - '0') + decNumber * 16;
                    break;
            }
        }
        return decNumber;
    }
}

