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

            //Get room repository option from user
            //string roomRepositoryOption = Utils.GetRoomsRepositoryOptionFromUser();
            //ConnectionType roomConnectionType = (roomRepositoryOption == "1" ? ConnectionType.File : ConnectionType.Hardcoded);

            //Get user repository option from user
            string userRepositoryOption = Utils.GetUsersRepositoryOptionFromUser();
            ConnectionType userConnectionType = (userRepositoryOption == "1" ? ConnectionType.File : ConnectionType.Hardcoded);

            //Get the print option from user
            string printOption = Utils.GetPrintOptionFromUser();

            //RoomServices roomServices = new RoomServices(roomConnectionType);
            //roomServices.Print(printOption);

            UserServices userServices = new UserServices(userConnectionType);
            userServices.Print(printOption);


            Console.ReadKey();



        }
    }
}
