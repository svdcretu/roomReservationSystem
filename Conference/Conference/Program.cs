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

            //UserServices userservices = new UserServices();
            //PrintUsers printusers = new PrintUsers();
            //printusers.Print(userservices.GetUsersAsString(), printOption);
            //Console.ReadKey();

            
            PrintRooms printRooms = new PrintRooms();
            ConnectionType connectionType = ConnectionType.Hardcoded;

            RoomServices roomServices = new RoomServices(connectionType);

            string rooms = roomServices.GetRoomsAsString(connectionType);
            printRooms.Print(rooms, printOption);

            //string rooms1 = roomServices.GetRoomAsString(connectionType, 1);
            //printRooms.Print(rooms1, printOption);

            Console.ReadKey();



        }
    }
}
