namespace MakeHuman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MainClass
    {
        public void CreateHuman(int uniqueNumber)
        {
            Human firstHumanAdam = new Human();
            firstHumanAdam.Age = uniqueNumber;
            if (uniqueNumber % 2 == 0)
            {
                firstHumanAdam.NameOfPerson = "Батката";
                firstHumanAdam.Gender = Gender.UltraBigBrother;
            }
            else
            {
                firstHumanAdam.NameOfPerson = "Мацето";
                firstHumanAdam.Gender = Gender.CoolGirl;
            }
        }
    }
}
