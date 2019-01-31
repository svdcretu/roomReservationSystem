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
            string printOption = PrintUtils.GetPrintOptionFromUser();

            UserServices userServices = new UserServices();
            PrintUsers printUsers = new PrintUsers();
            printUsers.Print(userServices.GetUsersAsString(), printOption);
            Console.ReadKey();


            //RoomServices roomServices = new RoomServices();
            //PrintRooms printRooms = new PrintRooms();
            //printRooms.Print(roomServices.GetRoomAsString(2), printOption);
            //Console.ReadKey();



        }
    }
}
