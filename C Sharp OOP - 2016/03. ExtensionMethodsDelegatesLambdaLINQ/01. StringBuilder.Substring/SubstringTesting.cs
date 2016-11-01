using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class SubstringTesting
    {
        public static void Main()
        {
            string text = "Ebasi qkiq tekst brato!";
            string textFromString = text.Substring(4, 5);
            Console.WriteLine("Text with the functionality substring from visual studio: {0}", textFromString);
            Console.WriteLine();

            StringBuilder textInStringBuilder = new StringBuilder();
            textInStringBuilder.Append("Ebasi qkiq tekst brato!");
            string textFromStringBuilder = textInStringBuilder.SubstringMethod(4, 5);
            Console.WriteLine("Text with the extension method \"SubstringMethod\": {0}",textFromStringBuilder);
            Console.WriteLine();
        }
    }
}
