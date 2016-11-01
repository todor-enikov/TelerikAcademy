using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_sentences
{
    class ExtractSentences
    {
        static void Main()
        {
            // string word = Console.ReadLine();
            // string text = Console.ReadLine();
            // string endSentences = ".";
            // int indexOfEndSentences = text.IndexOf(endSentences);

            // string input = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            string word = Console.ReadLine();
            string input = Console.ReadLine();
            input = input.Replace(@"\", string.Empty);
            input = input.Replace(@"""", string.Empty);

            string[] sentances = input.Split('.');
            StringBuilder sentencesWithWord = new StringBuilder();
            foreach (var sentance in sentances)
            {
                if (sentance.Contains(' ' + word + ' '))
                {
                    sentencesWithWord.Append(sentance + ".");
                }
            }
            Console.WriteLine(sentencesWithWord);
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//
//namespace _08_Extract_Sentences_2
//{
//    class ExtractSentences2
//    {
//        static void Main()
//        {    //TODO: 90/100
//            // Sentences separated by DOT, 
//            // words separated by non letter symbols
//            var separator = ".";
//
//            // {0} sentence {1} separator
//            var sentenceFormat = "{0}{1}";
//
//            // Word to find.
//            var toFindWord = Console.ReadLine();
//
//            // Text to search.
//            var toParseSentences = Console
//                .ReadLine()
//                .Split(separator.ToCharArray())
//                .ToArray();
//
//            // Get a List of words with different
//            // cases upper, lower, capitalized
//            var toFind = GetWords(toFindWord);
//
//            var output = new StringBuilder();
//
//            foreach (var sentence in toParseSentences)
//            {
//                if (ContainsWord(sentence, toFind))
//                {
//
//                    output.Append(
//                        string.Format(
//                            sentenceFormat,
//                            sentence,
//                            separator
//                            ));
//                }
//            }
//
//            Console.WriteLine(output);
//        }
//
//        static List<string> GetWords(string Word)
//        {
//            var toReturn =
//                new List<string>()
//                {
//                    Word,
//                    Word.ToLower(),
//                    Word.ToUpper(),
//                    Word.Replace(
//                        Word[0],
//                        char.ToUpper(Word[0])),
//                    (Word + "'s"),
//                    (Word + "'")
//                };
//
//            return toReturn;
//        }
//
//        // TOO SLOW
//        static List<string> GenerateAllCases(string Word)
//        {
//            var curWordVariation = new StringBuilder();
//
//            var toReturn = new List<string>();
//
//            toReturn.Add(Word);
//
//            var WordToLower = Word.ToLower();
//
//            toReturn.Add(WordToLower);
//            toReturn.Add(Word.ToUpper());
//
//            for (int curEndPoint = 0; 
//                     curEndPoint < Word.Length; 
//                     curEndPoint++)
//            {
//                for (int curStartPoint = 0; 
//                         curStartPoint <= curEndPoint;
//                         curStartPoint++)
//                {
//                    //reset the string builder
//                    curWordVariation.Clear();
//
//                    // Everything BEFORE StartPont AS IS 
//                    for (int curIndex = 0; 
//                             curIndex < curStartPoint; 
//                             curIndex++)
//                    {
//                        curWordVariation.Append(WordToLower[curIndex]);
//                    }
//                    // Everuthing BETWEEN StartPoint and EndPoint to UPPER
//                    for (int curIndex = curStartPoint; 
//                             curIndex <= curEndPoint; 
//                             curIndex++)
//                    {
//                        curWordVariation.Append(char.ToUpper(WordToLower[curIndex]));
//                    }
//                    // Everything AFTER EndPoint AS IS 
//                    for (int curIndex = curEndPoint + 1; 
//                             curIndex < WordToLower.Length; 
//                             curIndex++)
//                    {
//                        curWordVariation.Append(WordToLower[curIndex]);
//                    }
//
//                    // Add the current variation to the list.
//                    toReturn.Add(curWordVariation.ToString());
//                }
//            }
//
//            return toReturn;
//        }
//
//        static bool ContainsWord(string Sentence, List<string> Words)
//        {
//            var toCheck = string.Format("^{0}$", Sentence.ToLower());
//
//            foreach (var word in Words)
//            {
//                var wordLength = word.Length;
//
//                var wordCurIndex = toCheck.IndexOf(word.ToLower());
//
//                // While the current sentece contains
//                // the current variation of the word.
//                while (wordCurIndex >= 0)
//                {
//                    // Check if the word string is a 
//                    // separate word.
//                    if (!char.IsLetter(toCheck[wordCurIndex - 1]) &&
//                        !char.IsLetter(toCheck[wordCurIndex + wordLength]))
//                    {
//                        return true;
//                    }
//                    
//                    // Find next occurance.
//                    wordCurIndex = toCheck.IndexOf(word.ToLower(), ++wordCurIndex);
//                }
//            }
//
//            return false;
//        }
//    }
//}

//using System;
//using System.Linq; // needed for Where()
//
//class ExtractSentences
//{
//    static void Main()
//    {
//        string wordSearch = Console.ReadLine().Trim();
//        string text = Console.ReadLine();
//
//        string[] sentences = text
//            .Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);
//        char[] separators = GetNonLetterSymbols(text);
//
//        foreach (string sentence in sentences)
//        {
//            string[] words = sentence
//                .Split(separators, StringSplitOptions.RemoveEmptyEntries);
//
//            foreach (var word in words)
//            {
//                if (word.Trim() == wordSearch)
//                {
//                    Console.Write(sentence.Trim() + ". ");
//                    break;
//                }
//            }
//        }
//
//    }
//
//    private static char[] GetNonLetterSymbols(string input)
//    {
//        char[] symbols = input
//            .Where(ch => !char.IsLetter(ch)) // needs System.Linq
//            .Distinct() // removes all duplicate elements in a collection; returns only the distinct elements
//            .ToArray();
//
//        return symbols;
//    }
//}