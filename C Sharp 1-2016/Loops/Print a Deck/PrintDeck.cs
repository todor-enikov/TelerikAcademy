//Write a program that reads a card sign(as a char) from the console and generates and prints all 
//possible cards from a standard deck of 52 cards up to the card with the given sign(without the jokers). 
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//    The card faces should start from 2 to A.
//    Print each card face in its four possible suits: clubs, diamonds, hearts and spades.

using System;

class PrintDeck
{
    static void Main()
    {
        string symbolCard = Console.ReadLine();
        switch (symbolCard)
        {
            case "2":
                for (int i = 2; i <= 2; i++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                break;
            case "3":
                for (int i = 2; i <= 3; i++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                break;
            case "4":
                for (int i = 2; i <= 4; i++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                break;
            case "5":
                for (int i = 2; i <= 5; i++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                break;
            case "6":
                for (int i = 2; i <= 6; i++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                break;
            case "7":
                for (int i = 2; i <= 7; i++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                break;
            case "8":
                for (int i = 2; i <= 8; i++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                break;
            case "9":
                for (int i = 2; i <= 9; i++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                break;
            case "10":
                for (int i = 2; i <= 10; i++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                break;
            case "J":
                for (int i = 2; i <= 11; i++)
                {
                    if (i == 11)
                    {
                        Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                    }
                    else if (i <= 10)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                    }

                }
                break;
            case "Q":
                for (int i = 2; i <= 11; i++)
                {
                    if (i == 11)
                    {
                        Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                        Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                    }
                    else if (i <= 10)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                    }

                }
                break;
            case "K":
                for (int i = 2; i <= 11; i++)
                {
                    if (i == 11)
                    {
                        Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                        Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                        Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                    }
                    else if (i <= 10)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                    }

                }
                break;
            case "A":
                for (int i = 2; i <= 11; i++)
                {
                    if (i == 11)
                    {
                        Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                        Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                        Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                        Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds");
                    }
                    else if (i <= 10)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                    }

                }
                break;
            default: Console.WriteLine("Invalid input!");
                break;
        }
    }
}

