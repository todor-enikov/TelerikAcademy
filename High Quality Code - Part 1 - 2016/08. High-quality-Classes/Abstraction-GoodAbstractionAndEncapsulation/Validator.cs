namespace Abstraction_GoodAbstractionAndEncapsulation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Validator
    {
        public static void CheckIfDoubleIsEqualToZero(double value)
        {
            if (value == 0)
            {
                throw new ArgumentException("The value cannot be equal to zero!");
            }
        }
    }
}
