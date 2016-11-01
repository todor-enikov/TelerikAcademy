using System;

namespace MobileDevice
{
    public class Battery
    {
        private string model;    //task1
        private decimal hoursIdle;    //task1
        private decimal hoursTalk;    //task1
        private BatteryType typeOfBattery; //task3

        public Battery() //task2
        {
            this.Model = "ordinary";
            this.HoursIdle = 0m;
            this.HoursTalk = 0m;
            this.TypeOfBattery = BatteryType.LiIon;
        }

        public Battery(string model, decimal hoursIdle, decimal hoursTalk, BatteryType phoneBatteryType) //task2
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.TypeOfBattery = phoneBatteryType;  //task3
        }

        public string Model //task5
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value.Length <= 0 || value.Length >= 20)
                {
                    throw new ArgumentException("The length of the model must be longer than 0 symbols and shorter than 20 symbols.");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public decimal HoursIdle //task5
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The hours idle of the battery can't be less than 0 hours.");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public decimal HoursTalk  //task5
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The hours of talking can't be less than 0 hours.");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public BatteryType TypeOfBattery //task5
        {
            get
            {
                return this.typeOfBattery;
            }
            set
            {
                this.typeOfBattery = value;
            }
        }
    }
}
