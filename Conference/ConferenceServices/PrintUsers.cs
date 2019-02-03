using System;
using ConferenceInterfaces;
using ConferenceUtils;


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
