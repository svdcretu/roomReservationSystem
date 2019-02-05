using ConferenceModels;
using ConferenceServices;
using ConferenceUtils;
using System;


namespace Conference
{
    class Program
    {
        static void Main(string[] args)
        {

            //Get repository option from user
            string repositoryOption = Utils.GetRoomsRepositoryOptionFromUser();
            ConnectionType connectionType = (repositoryOption == "1" ? ConnectionType.File : ConnectionType.Hardcoded);

            //Get the print option from user
            string printOption = Utils.GetPrintOptionFromUser();

            PrintRooms printRooms = new PrintRooms();
            RoomServices roomServices = new RoomServices(connectionType);
            string rooms = roomServices.GetRoomsAsString(connectionType);
            printRooms.Print(rooms, printOption);

            //string rooms1 = roomServices.GetRoomAsString(connectionType, 1);
            //printRooms.Print(rooms1, printOption);

            Console.ReadKey();



        }
    }
}
