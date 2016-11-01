namespace RefactoringAndImprovingTheCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PlayerInformation
    {
        private string name;
        private int collectedPoints;

        public PlayerInformation()
        {
        }

        public PlayerInformation(string name, int collectedPoits)
        {
            this.name = name;
            this.collectedPoints = collectedPoits;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int CollectedPoints
        {
            get { return this.collectedPoints; }
            set { this.collectedPoints = value; }
        }
    }
}
