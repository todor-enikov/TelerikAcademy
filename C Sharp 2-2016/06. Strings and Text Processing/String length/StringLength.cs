using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        string text = Console.ReadLine();
        text = text.Replace(@"\", string.Empty);
        StringBuilder newText = new StringBuilder();

        int currentLength = 20 - text.Length;
        if (text.Length < 20)
        {
            text = text + newText.Append('*', currentLength).ToString();
            Console.WriteLine(text);
        }
        else
        {
            Console.WriteLine(text);
        }

    }
}

