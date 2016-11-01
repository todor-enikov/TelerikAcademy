using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range_Exceptions
{
    public class InvalidRangeException<T> : ApplicationException
        where T:IComparable
    {
        
        public InvalidRangeException(string message, T start, T end) 
            : base(message)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start { get; set; }
        public T End { get; set; }
    }
}
