namespace ControlFlowCSLoops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Chef
    {     
        public void Cook()
        {
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();

            Peel(potato);
            Peel(carrot);

            Bowl bowl = this.GetBowl();

            this.Cut(potato);
            bowl.Add(potato);

            this.Cut(carrot);
            bowl.Add(carrot);
        }

        private Potato GetPotato()
        {
            ////...
        }

        private Carrot GetCarrot()
        {
            ////...
        }

        private Bowl GetBowl()
        {
            ////... 
        }

        private void Cut(Vegetable potato)
        {
            ////...
        }
    }
}
