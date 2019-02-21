using BusinesServices.Contracts;
using BusinesServices.DisplayInfo;
using BusinesServices.UserBusiness;
using ConferenceModels;
using ConferenceRepository.Contracts;
using ConferenceRepository.UserRepository;
using ConferenceRepository.RoomRepository;
using ConferenceUtils;
using System;

namespace Conference
{
    class Program
    {
        static void Main(string[] args)
        {

            //IBusinesService<User> userService;
            //IDisplayService<User> userDisplayService;
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
            //    userDisplayService = new DisplayUserServiceFile();
            //}
            //else
            //{
            //    userDisplayService = new DisplayUserServiceConsole();
            //}

            //userService = new UserService(userRepository, userDisplayService);

            //var userList = userService.GetData();
            //userService.Display(userList);
            //var user = userService.GetDataById(15);           
            //userService.Display(user);


            IBusinesService<ConferenceRoom> roomService;
            IDisplayService<ConferenceRoom> roomDisplayService;
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
                roomDisplayService = new DisplayRoomServiceFile();
            }
            else
            {
                roomDisplayService = new DisplayRoomServiceConsole();
            }

            roomService = new RoomService(roomRepository, roomDisplayService);

            var roomList = roomService.GetData();
            roomService.Display(roomList);
            var room = roomService.GetDataById(15);
            roomService.Display(room);

            Console.ReadKey();



        }
    }
}
