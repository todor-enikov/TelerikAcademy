using System;
using System.Numerics;

public class Messages
{
    public static void Main()
    {
        string firstNumber = Console.ReadLine().Replace("cad", "0")
                                             .Replace("xoz", "1")
                                             .Replace("nop", "2")
                                             .Replace("cyk", "3")
                                             .Replace("min", "4")
                                             .Replace("mar", "5")
                                             .Replace("kon", "6")
                                             .Replace("iva", "7")
                                             .Replace("ogi", "8")
                                             .Replace("yan", "9");
        string operation = Console.ReadLine();
        string secondNumber = Console.ReadLine().Replace("cad", "0")
                                             .Replace("xoz", "1")
                                             .Replace("nop", "2")
                                             .Replace("cyk", "3")
                                             .Replace("min", "4")
                                             .Replace("mar", "5")
                                             .Replace("kon", "6")
                                             .Replace("iva", "7")
                                             .Replace("ogi", "8")
                                             .Replace("yan", "9");
        BigInteger currentFirstNumber = BigInteger.Parse(firstNumber);
        BigInteger currentSecondNumber = BigInteger.Parse(secondNumber);

        BigInteger currentNumber = 0;

        if (operation == "-")
        {
            currentNumber = currentFirstNumber - currentSecondNumber;
        }
        else if (operation == "+")
        {
            currentNumber = currentFirstNumber + currentSecondNumber;
        }
        else if (operation == "*")
        {
            currentNumber = currentFirstNumber * currentSecondNumber;
        }
        else if (operation == "/")
        {
            currentNumber = currentFirstNumber / currentSecondNumber;
        }

        string finalNumber = currentNumber.ToString().Replace("0", "cad")
                                                     .Replace("1", "xoz")
                                                     .Replace("2", "nop")
                                                     .Replace("3", "cyk")
                                                     .Replace("4", "min")
                                                     .Replace("5", "mar")
                                                     .Replace("6", "kon")
                                                     .Replace("7", "iva")
                                                     .Replace("8", "ogi")
                                                     .Replace("9", "yan");
        Console.WriteLine(finalNumber);
    }
}