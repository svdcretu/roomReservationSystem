using ConferenceUtils;
using System;


namespace ConferenceServices
{
    public class PrintEntity
    {
        public static void Print(string text, string destination)
        {
            if (!String.IsNullOrEmpty(text))
            {
                Console.WriteLine("############### Printing data ###############");
                switch (destination)
                {
                    case "1":
                        Utils.PrintToFile(text);
                        break;
                    case "2":
                    default:
                        Console.WriteLine(text);
                        break;
                }
                Console.WriteLine("############### End printing ###############");
            }
        }
    }
}
