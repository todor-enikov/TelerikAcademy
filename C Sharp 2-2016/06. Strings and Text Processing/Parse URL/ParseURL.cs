using System;


namespace Parse_URL
{
    class ParseURL
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int serverIndex = input.IndexOf("://");
            int resources = input.Substring(serverIndex + 3).IndexOf("/") + serverIndex + 3;
            Console.WriteLine("[protocol] = " + input.Substring(0, serverIndex));
            Console.WriteLine("[server] = " + input.Substring(serverIndex + 3, resources - serverIndex - 3));
            Console.WriteLine("[resources] = " + input.Substring(resources));


        }
    }
}

// int resIndex = input.Substring(serverIndex + 3).IndexOf("/") + serverIndex + 3;
// Console.WriteLine("[protocol] = " + input.Substring(0, serverIndex));
// Console.WriteLine("[server] = " + input.Substring(serverIndex + 3, resIndex - serverIndex - 3));
// Console.WriteLine("[resource] = " + input.Substring(resIndex));