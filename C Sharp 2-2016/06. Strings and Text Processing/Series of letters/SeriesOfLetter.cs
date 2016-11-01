using System;
using System.Text;


namespace Series_of_letters
{
    class SeriesOfLetter
    {
        static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder output = new StringBuilder();

            output.Append(input[0]);

            foreach (char letter in input)
            {
                char prevLetter = output[output.Length - 1];

                if (!char.IsLetter(letter))
                {
                    continue;
                }

                if (letter == prevLetter)
                {
                    continue;
                }
                else
                {
                    output.Append(letter);
                }
            }

            Console.WriteLine(output);
        }
    }
}

