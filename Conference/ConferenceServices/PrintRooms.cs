using System;
using ConferenceInterfaces;
using ConferenceUtils;
using ConferenceModels;
using System.Collections.Generic;

namespace ConferenceServices
{
    public class PrintRooms : IPrint
    {

        public void Print(string text, string destination)
        {
            if (!String.IsNullOrEmpty(text))
            {
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

            }
        }


    }
}
