using BusinesServices.Contracts;
using BusinesServices.Print;
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

            #region ConferenceRoom
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
            #endregion



            //#region User
            //UserService userService;
            //IPrint<User> userDisplayService;
            //IRepository<User> userRepository;

            ////Get user repository option from user
            //string userRepositoryOption = Utils.GetUsersRepositoryOptionFromUser();
            //ConnectionType userConnectionType = (userRepositoryOption == "1" ? ConnectionType.File : ConnectionType.Hardcoded);

            //if (userConnectionType == ConnectionType.Hardcoded)
            //{
            //    userRepository = new HardCodedUserRepository();
            //}
            //else
            //{
            //    userRepository = new FileBaseUserRepository();
            //}

            ////Get user print option from user
            //string userPrintOption = Utils.GetPrintOptionFromUser();

            //if (userPrintOption == "1")
            //{
            //    userDisplayService = new PrintToFile<User>();
            //}
            //else
            //{
            //    userDisplayService = new PrintToConsole<User>();
            //}

            //userService = new UserService(userRepository, userDisplayService);

            //var userList = userService.GetData();
            //userService.Print(userList);
            //var user = userService.GetDataById(2);
            //userService.Print(user);
            //Console.ReadKey();
            //#endregion


        }
    }
}
