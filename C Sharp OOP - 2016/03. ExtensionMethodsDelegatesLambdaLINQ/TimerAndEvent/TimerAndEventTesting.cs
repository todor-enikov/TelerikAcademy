using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerAndEvent
{
    class TimerAndEventTesting
    {
        static void Main()
        {
            Console.WriteLine("Testing Timer");

            // interval is 1000 because subscriber counting secs
            var timer = new Timer(1000);

            timer.Start();
        }
    }
}
