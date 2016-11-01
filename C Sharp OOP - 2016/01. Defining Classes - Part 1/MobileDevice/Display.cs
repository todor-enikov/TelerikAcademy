using System;


namespace MobileDevice
{
    public class Display
    {
        private double size;    //task1
        private long numberOfColors;    //task1

        public Display() //task2
        {
            this.Size = 0;
            this.NumberOfColors = 0;
        }

        public Display(double phoneSize, long phoneNumberOfColors) //task2
        {
            this.Size = phoneSize;
            this.NumberOfColors = phoneNumberOfColors;
        }

        public double Size //task5
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < 3 || value > 10)
                {
                    throw new ArgumentException("The size of the display must be between 3 and 10 inches.");
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public long NumberOfColors  //task5
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value <= 2)
                {
                    throw new ArgumentException("The colors of the phone can't be less than 2");
                }
                else
                {
                    this.numberOfColors = value;
                }
            }
        }
    }
}
