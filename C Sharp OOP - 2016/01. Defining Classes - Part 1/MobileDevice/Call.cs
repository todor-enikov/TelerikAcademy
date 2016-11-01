using System;
using System.Text;

namespace MobileDevice
{
    public class Call //task8
    {
        private string date;
        private string time;
        private string dialledPhoneNumber;
        private decimal duration;

        public Call(string currentDate,string currentTime, string phoneNumber, decimal currentDuration)
        {
            this.Date = currentDate;
            this.Time = currentTime;
            this.DialledPhoneNumber = phoneNumber;
            this.Duration = currentDuration;
        }
        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                if (value.Length != 10)
                {
                    throw new ArgumentException("The date must be exactly 10 symbols in the format dd.mm.yyyy");
                }
                else
                {
                    this.date = value;
                }
            }
        }

        public string Time
        {
            get
            {
                return this.time;
            }
            set
            {
                if (value.Length != 5)
                {
                    throw new ArgumentException("The time must be in current format: hh:mm");
                }
                else
                {
                    this.time = value;
                }
            }
        }

        public string DialledPhoneNumber { get; set; }


        public decimal Duration
        {
            get { return this.duration; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The duration can't be less than 0 seconds");
                }
                else
                {
                    this.duration = value;
                }
            }
        }

        public override string ToString() //task12
        {
            StringBuilder phoneInformation = new StringBuilder();
            phoneInformation.AppendFormat("Date: {0} Time: {1} Dialled Phone Number: {2} Duration: {3}\n", this.Date,this.Time,this.DialledPhoneNumber, this.Duration);
            return phoneInformation.ToString();
        }

    }
}
