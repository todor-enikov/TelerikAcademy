using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolclasses
{
    public class Disciplines : IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Disciplines(string nameDiscipline, int numberLectures, int numberExercises)
        {
            this.Name = nameDiscipline;
            this.NumberOfLectures = numberLectures;
            this.NumberOfExercises = numberExercises;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;

            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The number of lectures cannot be less or equal to zero!");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The number of exercises cannot be less or equal to zero!");
                }
                this.numberOfExercises = value;
            }
        }

        public string Comments { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendFormat("\nIn discipline {0} there are {1} number of Lectures and there are {2} number of Exercises",
                this.Name, this.NumberOfLectures, this.NumberOfExercises);
            return result.ToString();
        }
    }
}
