using System;
using System.Collections.Generic;

namespace MobileDevice
{
    public class GSMCallHistoryTest
    {
        public static void AddingCalls()
        {
            GSM samsung = new GSM("Galaxy Note 3", "Samsung", 200, "Bai Veselin",
            new Battery("Removable", 2, 6, BatteryType.LiIon),
            new Display(5.7, 25600000));

            samsung.Adding(new Call("10.06.2016", "16:48", "0886014325", 0.06m));
            samsung.Adding(new Call("11.06.2016", "17:48", "0886014325", 0.56m));
            samsung.Adding(new Call("13.06.2016", "19:18", "0886014425", 0.36m));
            samsung.Adding(new Call("14.06.2016", "06:45", "0886014325", 0.26m));
            samsung.Adding(new Call("15.06.2016", "16:43", "0886018625", 0.12m));

            foreach (var call in samsung.CallHistory)
            {
                Console.WriteLine(call.ToString());
            }
            Console.WriteLine("Call Price before removing a call: {0:F5}", samsung.CallPrice());
            List<Call> calls = samsung.CallHistory;
            decimal currentCall = 0;
            int index = 0;
            for (int i = 0; i < calls.Count; i++)
            {
                if (currentCall < calls[i].Duration)
                {
                    currentCall = calls[i].Duration;
                    index = i;
                }
            }
            samsung.Deleting(index);
            Console.WriteLine("Call price after removing a call: {0:F5}", samsung.CallPrice());
            samsung.Clear();
            foreach (var call in samsung.CallHistory)
            {
                Console.WriteLine(call.ToString());
            }
        }



    }
}
