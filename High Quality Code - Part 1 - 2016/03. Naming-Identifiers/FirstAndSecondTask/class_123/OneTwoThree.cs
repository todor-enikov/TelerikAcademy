namespace Class_123
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OneTwoThree
    {
        private const int MaxCount = 6;

        public static void Main()
        {
            OneTwoThree.ClassInsideClassOneTwoThree instance = new OneTwoThree.ClassInsideClassOneTwoThree();
            instance.PrintingVariableAsString(true);
        }

        public class ClassInsideClassOneTwoThree
        {
            public void PrintingVariableAsString(bool initialVariable)
            {
                string initialVariableAsString = initialVariable.ToString();
                Console.WriteLine(initialVariableAsString);
            }
        }
    }
}
