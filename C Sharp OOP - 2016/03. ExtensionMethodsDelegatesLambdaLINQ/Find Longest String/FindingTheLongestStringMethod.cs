using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Longest_String //task17
{
    public static class FindingTheLongestStringMethod
    {
        public static string FindingString(this string[] wordsString)
        {
            var result= (from word in wordsString
                        orderby word.Length descending
                        select word).ToArray()[0];
            return result;
        }
    }
}
