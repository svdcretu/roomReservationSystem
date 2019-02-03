using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConferenceServices;
using ConferenceModels;
using ConferenceUtils;


namespace Conference
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the print option from user
            string printOption = Utils.GetPrintOptionFromUser();

            UserServices userservices = new UserServices();
            PrintUsers printusers = new PrintUsers();
            printusers.Print(userservices.GetUsersAsString(), printOption);
            Console.ReadKey();


            //RoomServices roomServices = new RoomServices(ConnectionType.File);
            //PrintRooms printRooms = new PrintRooms();
            //string rooms = roomServices.GetRooms(ConnectionType.Hardcoded);
            //printRooms.Print(rooms, printOption);
            //Console.ReadKey();



        }
    }
}
