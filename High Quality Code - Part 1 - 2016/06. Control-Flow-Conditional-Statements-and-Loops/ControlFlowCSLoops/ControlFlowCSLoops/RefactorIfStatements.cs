namespace ControlFlowCSLoops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RefactorIfStatements
    {
        public void RefactotringFirstIfStatement()
        {
            Potato potato;

            if (potato != null)
            {
                if (potato.HasBeenPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
                else
                {
                    ////Do some other stuff.
                }
            }
            else
            {
                return;
            }
        }

        public void RefactoringSecondIfStatement()
        {
            bool isYInBorders = MAX_Y >= y && MIN_Y <= y;
            bool isXBiggerThanMin = x >= MIN_X;
            bool isXLessThanMax = x <= MAX_X;
            if (isXBiggerThanMin && (isXLessThanMax && (isYInBorders && shouldVisitCell)))
            {
                VisitCell();
            }
            else
            {
                ////Do nothing more.
            }
        }
    }
}
