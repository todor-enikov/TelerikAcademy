using System;
using System.Collections.Generic;


namespace MobileDevice
{
    public class GSMTest
    {
        public static void TestingGSM() //task7
        {
            List<GSM> allMobileDevices = new List<GSM>();
            allMobileDevices.Add(new GSM("Galaxy Note 3", "Samsung", 200, "Bai Veselin",
            new Battery("Removable", 2, 6, BatteryType.LiIon),
            new Display(5.7, 25600000)));
            allMobileDevices.Add(new GSM("Galaxy Alpha", "Samsung", 600, "Sperplatov",
            new Battery("Removable", 3, 8, BatteryType.NiCd),
            new Display(4.5, 1600000)));
            allMobileDevices.Add(new GSM("Iphone5s", "Apple", 800, "Bai Shile",
            new Battery("Non-removable", 18, 13, BatteryType.NiMH),
            new Display(3.5, 13600000)));

            foreach (var gsm in allMobileDevices)
            {
                Console.WriteLine(gsm.ToString());
            }
            Console.WriteLine(GSM.Iphone4S.ToString());
        }
    }
}
