using System;

namespace Parse_tags
{
    class ParseTags
    {
        static void Main()
        {
            //40/100

            string text = Console.ReadLine();

            string startTag = "<upcase>";
            string endTag = "</upcase>";

            int startTagIndex = text.IndexOf(startTag);
            int endTagIndex = text.IndexOf(endTag);


            while (startTagIndex >= 0 && endTagIndex >= 0)
            {

                text = text.Replace(text.Substring(startTagIndex, endTagIndex - startTagIndex),
                                    text.Substring(startTagIndex, endTagIndex - startTagIndex)
                                           .ToUpper());

                text = text.Remove(endTagIndex, endTag.Length);
                text = text.Remove(startTagIndex, startTag.Length);

                startTagIndex = startTagIndex + 1;
                startTagIndex = text.IndexOf(startTag, startTagIndex);

                try
                {
                    endTagIndex = endTagIndex + 1;
                    endTagIndex = text.IndexOf(endTag, endTagIndex);
                }
                catch (ArgumentOutOfRangeException)
                {

                    endTagIndex = -1;
                }               
            }

            Console.WriteLine(text);
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//
//namespace _05_Parse_Tags_3
//{
//    class ParseTags3
//    {
//        // 100/ 100
//        static void Main()
//        {
//            var openTag = "upcase";
//            var closeTag = "/upcase";
//
//            var toParse = Console
//                .ReadLine()
//                .Split(new char[] { '<', '>' })
//                .ToArray();
//
//            var output = new StringBuilder();
//            var toUpper = false;
//
//            foreach (var word in toParse)
//            {
//                if (word == openTag)
//                {
//                    toUpper = true;
//                    continue;
//                }
//
//                if (word == closeTag)
//                {
//                    toUpper = false;
//                    continue;
//                }
//
//                if (toUpper)
//                {
//                    output.Append(word.ToUpper());
//                }
//                else
//                {
//                    output.Append(word);
//                }
//            }
//
//            Console.WriteLine(output);
//        }
//    }
//}