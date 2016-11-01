using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerAndEvent
{
    class Event //task8
    {
        public Event()
        {
            this.Time = DateTime.Now;
        }

        public DateTime Time { get; private set; }

        public override string ToString()
        {
            return Time.Day + " " + Time.Month + " " + Time.Year;
        }
    }
}
