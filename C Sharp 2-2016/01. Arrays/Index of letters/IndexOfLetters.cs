using System;

class IndexOfLetters
{
    static void Main()
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        char[] arrayAlphabet = alphabet.ToCharArray();

        string word = Console.ReadLine();
        char[] arrayOfWord = word.ToCharArray();

        for (int i = 0; i < arrayOfWord.Length; i++)
        {
            int result = Array.BinarySearch(arrayAlphabet, arrayOfWord[i]);
            Console.WriteLine(result);
        }
    }
}

