using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Replace_tags_1
{
    class Program
    {
        //30/100
        public static string ReadingMultilineText()
        {
            StringBuilder text = new StringBuilder();
            string input;
            while (!String.IsNullOrWhiteSpace(input = Console.ReadLine()))
            {
                text.AppendLine((FindandReplace(input)));
            }
            return text.ToString().Trim();
        }
        static void Main(string[] args)
        {
            string input = ReadingMultilineText();
            Console.WriteLine(input);
        }
        public static string FindandReplace(string line)
        {
            string pattern1 = @"<a href=""";
            string pattern2 = @""">";
            string pattern3 = @"</a>";
            StringBuilder text = new StringBuilder();
            text.Append(line);
            List<int> stack1 = (KMPSearch(pattern1, text.ToString()));
            List<int> stack2 = (KMPSearch(pattern2, text.ToString()));
            List<int> stack3 = (KMPSearch(pattern3, text.ToString()));

            ///////////////////////////////
            //Insert Brackets//////////////
            ///////////////////////////////

            while (stack1.Count > 0 && stack2.Count > 0 && stack3.Count > 0)
            {
                int index1 = stack1.Count - 1;
                int index2 = stack2.Count - 1;
                int index3 = stack3.Count - 1;
                while (stack1.Count > 0)
                {
                    if (stack1[index1] > stack2[index2])
                    {
                        stack1.RemoveAt(index1); index1 = stack1.Count - 1; continue;
                    }
                    break;
                }
                while (stack2.Count > 0)
                {
                    if (stack2[index2] > stack3[index3])
                    {
                        stack2.RemoveAt(index2); index2 = stack2.Count - 1; continue;
                    }
                    break;
                }
                while (stack3.Count > 0)
                {

                    if (index3 - 1 > 0 && stack3[index3 - 1] > stack2[index2])
                    {
                        stack3.RemoveAt(index3); index3 = stack3.Count - 1; continue;
                    }
                    break;
                }
                text.Insert(stack3[index3], "]");
                text.Insert(stack2[index2] + 2, "[");
                text.Insert(stack2[index2], ")");
                text.Insert(stack1[index1] + 9, "(");
                stack1.RemoveAt(index1);
                stack2.RemoveAt(index2);
                stack3.RemoveAt(index3);
            }
            stack1 = (KMPSearch(pattern1, text.ToString()));
            stack2 = (KMPSearch(pattern2, text.ToString()));
            stack3 = (KMPSearch(pattern3, text.ToString()));

            ///////////////////////////////
            //Insert [TEXT] BEFORE (URL)///
            ///////////////////////////////

            while (stack1.Count > 0 && stack2.Count > 0 && stack3.Count > 0)
            {
                int index1 = stack1.Count - 1;
                int index2 = stack2.Count - 1;
                int index3 = stack3.Count - 1;
                while (stack1.Count > 0)
                {
                    if (stack1[index1] > stack2[index2])
                    {
                        stack1.RemoveAt(index1); index1 = stack1.Count - 1; continue;
                    }
                    break;
                }
                while (stack2.Count > 0)
                {
                    if (stack2[index2] > stack3[index3])
                    {
                        stack2.RemoveAt(index2); index2 = stack2.Count - 1; continue;
                    }
                    break;
                }
                while (stack3.Count > 0)
                {

                    if (index3 - 1 > 0 && stack3[index3 - 1] > stack2[index2])
                    {
                        stack3.RemoveAt(index3); index3 = stack3.Count - 1; continue;
                    }
                    break;
                }
                string insert = text.ToString(stack2[index2] + 2, stack3[index3] - stack2[index2] - 2);
                text.Insert(stack1[index1] + 9, insert);
                stack1.RemoveAt(index1);
                stack2.RemoveAt(index2);
                stack3.RemoveAt(index3);

            }

            stack1 = (KMPSearch(pattern1, text.ToString()));
            stack2 = (KMPSearch(pattern2, text.ToString()));
            stack3 = (KMPSearch(pattern3, text.ToString()));

            ///////////////////////////////
            //REMOVE ADDITIONAL [TEXT]/////
            ///////////////////////////////


            while (stack1.Count > 0 && stack2.Count > 0 && stack3.Count > 0)
            {
                int index1 = stack1.Count - 1;
                int index2 = stack2.Count - 1;
                int index3 = stack3.Count - 1;
                while (stack1.Count > 0)
                {
                    if (stack1[index1] > stack2[index2])
                    {
                        stack1.RemoveAt(index1); index1 = stack1.Count - 1; continue;
                    }
                    break;
                }
                while (stack2.Count > 0)
                {
                    if (stack2[index2] > stack3[index3])
                    {
                        stack2.RemoveAt(index2); index2 = stack2.Count - 1; continue;
                    }
                    break;
                }
                while (stack3.Count > 0)
                {

                    if (index3 - 1 > 0 && stack3[index3 - 1] > stack2[index2])
                    {
                        stack3.RemoveAt(index3); index3 = stack3.Count - 1; continue;
                    }
                    break;
                }
                text.Remove(stack2[index2], stack3[index3] + 4 - stack2[index2]);
                text.Remove(stack1[index1], 9);
                stack1.RemoveAt(index1);
                stack2.RemoveAt(index2);
                stack3.RemoveAt(index3);
            }
            return text.ToString();
        }
        public static List<int> KMPSearch(string pattern, string text)
        {
            int n = text.Length;
            int m = pattern.Length;
            List<int> stack = new List<int>();

            // precompute

            int[] fl = new int[m + 1];
            fl[0] = -1;

            for (int i = 1; i < m; i++)
            {
                int j = fl[i];
                while (j >= 0 && pattern[j] != pattern[i])
                {
                    j = fl[j];
                }
                fl[i + 1] = j + 1;
            }

            // search

            int matched = 0;
            for (int i = 0; i < n; i++)
            {
                while (matched >= 0 && text[i] != pattern[matched])
                {
                    matched = fl[matched];
                }

                matched++;

                if (matched == m)
                {
                    stack.Add(i - m + 1);
                    matched = fl[matched];
                }
            }
            return stack;
        }
    }
}

//using System;
//using System.Text;
//using System.Text.RegularExpressions;
//
//class ReplaceTags
//{     //compilation Error
//    static void Main()
//    {
//        // first way => 10 runtime errors => 0/100
//        string hTMLDoc = Console.ReadLine();
//
//        StringBuilder tagReplaced = new StringBuilder();
//
//        string[] text = hTMLDoc
//            .Split(new string[] { "<a href", "</a>" }, StringSplitOptions.None);
//        // The return value includes array elements that contain an empty string
//
//        foreach (var word in text)
//        {
//            int indexOfLink = word.IndexOf("=\"");
//
//            if (indexOfLink >= 0)
//            {
//                int endIndex = word.IndexOf("\">");
//                tagReplaced.Append("[");
//                tagReplaced.Append(word.Substring(endIndex + 2, word.Length - endIndex - 2));
//                tagReplaced.Append("](");
//                tagReplaced.Append(word.Substring(indexOfLink + 2, endIndex - indexOfLink - 2));
//                tagReplaced.Append(")");
//            }
//            else
//            {
//                tagReplaced.Append(word);
//            }
//        }
//
//        if (tagReplaced.Length == 0)
//        {
//            Console.WriteLine(hTMLDoc);
//        }
//        else
//        {
//            Console.WriteLine(tagReplaced.ToString());
//        }
//
//        //other way => 2 Memory Limits => 0/100
//        //string hTML = Console.ReadLine();
//        //string pattern = @"<a href=""(.*?)"">(.*?)</a>";
//        //string replacement = @"[$2]($1)";
//        //Console.WriteLine(Regex.Replace(hTML, pattern, replacement));
//
//    }
//}


//using System;
//using System.Text;
//using System.Text.RegularExpressions;
//
//class ReplaceTags
//{   //100/100
//    static void Main()
//    {       
//        string hTML = Console.ReadLine();
//        string pattern = @"<a href=""(.*?)"">(.*?)</a>";
//        string replacement = @"[$2]($1)";
//        Console.WriteLine(Regex.Replace(hTML, pattern, replacement));
//    }
//}