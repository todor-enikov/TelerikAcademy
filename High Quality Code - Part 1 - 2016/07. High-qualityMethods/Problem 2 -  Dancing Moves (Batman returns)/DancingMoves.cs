using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DancingMoves
{
    public static void Main()
    {
        int[] arrayOfNumbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int startingPosition = 0;
        double currentSum = 0;
        double counter = 0;

        while (true)
        {
            string[] conditions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (conditions[0] == "stop")
            {
                break;
            }

            int timesToMove = int.Parse(conditions[0]);
            string direction = conditions[1];
            int step = int.Parse(conditions[2]);

            for (int i = 1; i <= timesToMove; i++)
            {
                int currentPosition = arrayOfNumbers[startingPosition];
                if (direction == "right")
                {
                    startingPosition = (startingPosition + step) % arrayOfNumbers.Length;
                }
                else if (direction == "left")
                {
                    startingPosition = (startingPosition - step) % arrayOfNumbers.Length;
                    if (startingPosition < 0)
                    {
                        startingPosition += arrayOfNumbers.Length;
                    }
                }

                currentSum += arrayOfNumbers[startingPosition];
            }

            counter++;
        }

        double finalsum = currentSum;
        double finalResult = finalsum / counter;
        Console.WriteLine("{0:F1}", finalResult);
    }
}