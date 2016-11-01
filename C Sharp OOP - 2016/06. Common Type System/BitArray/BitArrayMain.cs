using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray
{
    class BitArrayMain
    {
        static void Main()
        {
            var longNum = new BitArray64();
            longNum[20] = 1;
            longNum[4] = 1;
            longNum[31] = 1;
            longNum[55] = 1;
            Console.WriteLine(longNum);
        }
    }
}
