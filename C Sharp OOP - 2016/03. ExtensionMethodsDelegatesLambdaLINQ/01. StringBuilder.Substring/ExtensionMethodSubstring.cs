using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    public static class ExtensionMethodSubstring
    {
        public static string SubstringMethod(this StringBuilder str, int index, int length)
        {
            string substringText = "";
            for (int i = index; i < index + length; i++)
            {
                substringText += str[i];
            }
            return substringText;
        }
    }
}
