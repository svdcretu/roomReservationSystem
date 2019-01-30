using System;
using System.Collections.Generic;
using System.Text;
using ConferenceModels;
using ConferenceUtils;
using ConferenceInterfaces;


namespace ConferenceServices 
{
    public class PrintUsers : IPrint
    {

        public void Print(string text, string destination)
        {
            switch (destination)
            {
                case "1":
                    PrintUtils.PrintToFile(text);
                    break;
                case "2":
                default:
                    Console.WriteLine(text);
                    break;
            }


        }
    }
}
