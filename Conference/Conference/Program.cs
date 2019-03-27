using BusinesServices.Contracts;
using BusinesServices.UserBusiness;
using ConferenceModels;
using ConferenceRepository.Contracts;
using ConferenceRepository.RoomRepository;
using ConferenceUtils;
using System;

namespace Conference
{
    class Program
    {
        static void Main(string[] args)
        {


            RoomService roomService;
            IPrint<ConferenceRoom> roomDisplayService;
            IRepository<ConferenceRoom> roomRepository;

            //Get room repository option from user
            string roomRepositoryOption = Utils.GetUsersRepositoryOptionFromUser();
            ConnectionType roomConnectionType = (roomRepositoryOption == "1" ? ConnectionType.File : ConnectionType.Hardcoded);

            if (roomConnectionType == ConnectionType.Hardcoded)
            {
                roomRepository = new HardcodedRoomRepository();
            }
            else
            {
                roomRepository = new FileBaseRoomRepository();
            }

            //Get user print option from user
            string roomPrintOption = Utils.GetPrintOptionFromUser();

            if (roomPrintOption == "1")
            {
                roomDisplayService = new PrintToFile<ConferenceRoom>();
            }
            else
            {
                roomDisplayService = new PrintToConsole<ConferenceRoom>();
            }

            roomService = new RoomService(roomRepository, roomDisplayService);

            var roomList = roomService.GetData();
            roomService.Print(roomList);

            var room = roomService.GetDataById(2);
            roomService.Print(room);

            Console.ReadKey();



        }
    }
}
