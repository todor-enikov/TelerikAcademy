using System;
using System.Text;
using System.Collections.Generic;

namespace MobileDevice
{
    public class GSM
    {
        public static GSM iPhone4S = new GSM("Iphone4s", "Apple", 300, "Bat Sali",
            new Battery("Non-removable", 0, 0, BatteryType.LiIon),
            new Display(3.5, 1600000)); //task6

        private Battery battery;    //task1
        private Display display;    //task1
        private string model;    //task1
        private string manufacturer;    //task1
        private decimal price;    //task1
        private string owner;    //task1
        private List<Call> callHistory; //task9

        public GSM() //task2
        {
            this.Battery = battery;
            this.Display = display;
            this.Model = "None";
            this.Manufacturer = "None";
            this.Price = 0m;
            this.Owner = "Nobody";
            this.CallHistory = new List<Call>(); //task9
        }

        public GSM(string phoneModel, string phoneManufacturer, decimal phonePrice, string phoneOwner, Battery phoneBattery, Display phoneDisplay) //task2
        {
            this.Battery = phoneBattery;
            this.Display = phoneDisplay;
            this.Model = phoneModel;
            this.Manufacturer = phoneManufacturer;
            this.Price = phonePrice;
            this.Owner = phoneOwner;
            this.CallHistory = new List<Call>(); //task9
        }
        public Battery Battery { get; set; }  //task5
        public Display Display { get; set; }  //task5


        public string Model  //task5
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

        public string Manufacturer  //task5
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value.Length <= 0 || value.Length >= 10)
                {
                    throw new ArgumentException("The length ot the manufacturer must be longer than 0 symbols and shorter than 11 symbols.");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public decimal Price  //task5
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The price must be greater than 0 USD");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner  //task5
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value.Length <= 0 || value.Length >= 20)
                {
                    throw new ArgumentException("The name of the owner can't be 0 symbols and musn't be longer than 21 symbols");
                }
                this.owner = value;
            }
        }

        public static GSM Iphone4S
        {
            get { return iPhone4S; }
            set { iPhone4S = value; }
        }



        public List<Call> CallHistory //task9
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }
        

        public override string ToString() //task4
        {
            StringBuilder phoneInformation = new StringBuilder();
            phoneInformation.AppendFormat("Model: {0}\n", this.Model);
            phoneInformation.AppendFormat("Manufacturer: {0}\n", this.Manufacturer);
            phoneInformation.AppendFormat("Price: {0}\n", this.Price);
            phoneInformation.AppendFormat("Owner: {0}\n", this.Owner);
            phoneInformation.AppendFormat("Battery Information--> Model: {0} Hours Idle: {1} Hours Talk: {2} Battery Type: {3}\n", this.Battery.Model, this.Battery.HoursIdle, this.Battery.HoursTalk, this.Battery.TypeOfBattery);
            phoneInformation.AppendFormat("Display Information--> Size: {0} Number Of Colors: {1}\n", this.Display.Size, this.Display.NumberOfColors);
            return phoneInformation.ToString();
        }

        public void Adding(Call calling) //task10
        {
            CallHistory.Add(calling);
        }

        public void Deleting(int position) //task10
        {
            CallHistory.RemoveAt(position);
            Console.WriteLine("Call was removed!");
        }

        public void Clear() //task10
        {
            CallHistory.Clear();
            Console.WriteLine("Calls are cleared!");
        }

        public decimal CallPrice(decimal currentPrice=0.37m) //task11
        {
            decimal allSeconds = 0;
            foreach (var call in CallHistory)
            {
                allSeconds += call.Duration;
            }
            decimal finalResult = (allSeconds / 60) * currentPrice;
            return finalResult;
        }
    }
}
