//Classical play cards use the following signs to designate the card face:
//2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and
//prints "yes CONTENT_OF_STRING" if it is a valid card sign or "no CONTENT_OF_STRING" otherwise.
using System;

class PlayedCard
{
    static void Main()
    {
        string card = Console.ReadLine();
        switch (card)
        {
            case "2": Console.WriteLine("yes {0}", card);
                break;
            case "3": Console.WriteLine("yes {0}", card);
                break;
            case "4": Console.WriteLine("yes {0}", card);
                break;
            case "5": Console.WriteLine("yes {0}", card);
                break;
            case "6": Console.WriteLine("yes {0}", card);
                break;
            case "7": Console.WriteLine("yes {0}", card);
                break;
            case "8": Console.WriteLine("yes {0}", card);
                break;
            case "9": Console.WriteLine("yes {0}", card);
                break;
            case "10": Console.WriteLine("yes {0}", card);
                break;
            case "J": Console.WriteLine("yes {0}", card);
                break;
            case "Q": Console.WriteLine("yes {0}", card);
                break;
            case "K": Console.WriteLine("yes {0}", card);
                break;
            case "A": Console.WriteLine("yes {0}", card);
                break;
            default: Console.WriteLine("no {0}", card);
                break;
        }
    }
}

