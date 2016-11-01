using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TimerAndEvent
{
    public delegate void PrintDate(object sender, EventArgs e);
    public class Timer //task7
    {
        public event PrintDate print;
        public Timer(int interval)
        {
            this.Interval = interval;
        }

        public int Interval { get; private set; }

        public void Start()
        {
            print += PrintDate;

            if (this.Interval == 0 || this.Interval < 0)
            {
                throw new ArgumentException("Time interval cannot be negative or zero!");
            }
            while (true)
            {

                Thread.Sleep(this.Interval);

                var args = new Event();

                CounterPrintDate();

                Console.WriteLine(args.ToString());
                Console.WriteLine();

            }
        }

        private static void PrintDate(object sender, EventArgs e)
        {
            Console.WriteLine("Print date now:");
        }

        public void CounterPrintDate()
        {
            if (this.print != null)
            {
                this.print(this, EventArgs.Empty);
            }
        }
    }
}
