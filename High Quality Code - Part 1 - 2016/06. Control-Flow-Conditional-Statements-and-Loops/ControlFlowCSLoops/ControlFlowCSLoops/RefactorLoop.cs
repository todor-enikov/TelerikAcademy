namespace ControlFlowCSLoops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RefactorLoop
    {
        public void RefactoringLoop()
        {
            int expectedResult = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                    if (array[i] == expectedValue)
                    {
                        expectedResult = 666;
                    }
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }
            //// More code here
            if (expectedResult == 666)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
