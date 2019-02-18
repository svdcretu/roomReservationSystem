using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConferenceInterfaces;
using ConferenceUtils;


namespace ConferenceServices
{
    public class PrintEntity 
    {
        public static void Print(string text, string destination)
        {
            if (!String.IsNullOrEmpty(text))
            {
                Console.WriteLine("-------Printing data--------");
                Console.WriteLine("");
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
                Console.WriteLine("-------End printing--------");
            }
        }
    }
}
