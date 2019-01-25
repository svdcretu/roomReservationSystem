using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConferenceModels;

namespace Conference
{
    class Program
    {
        static void Main(string[] args)
        {
            ConferenceRoom conf1 = new ConferenceRoom(1);
            conf1.Description = "Conference 1";

            Console.WriteLine(conf1.Description);
            Console.ReadLine();


        }
    }
}
