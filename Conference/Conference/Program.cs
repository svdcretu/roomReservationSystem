using ConferenceModels;
using ConferenceServices;
using ConferenceUtils;
using System;

using BusinesServices.Contracts;
using BusinesServices.DisplayInfo;
using BusinesServices.UserBusiness;

using ConferenceRepository.Contracts;
using ConferenceRepository.UserRepository;

namespace Conference
{
    class Program
    {
        static void Main(string[] args)
        {

            IBusinesService<User> userService;
            IDisplayService<User> userDisplayService = new DisplayUserService();
            IRepository<User> userRepository;

            //Get room repository option from user
            //string roomRepositoryOption = Utils.GetRoomsRepositoryOptionFromUser();
            //ConnectionType roomConnectionType = (roomRepositoryOption == "1" ? ConnectionType.File : ConnectionType.Hardcoded);

            //Get user repository option from user
            string userRepositoryOption = Utils.GetUsersRepositoryOptionFromUser();
            ConnectionType userConnectionType = (userRepositoryOption == "1" ? ConnectionType.File : ConnectionType.Hardcoded);

            if (userConnectionType == ConnectionType.Hardcoded)
            {
                userRepository = new HardCodedUserRepository();
            }
            else
            {
                userRepository = new FileBaseUserRepository();
            }

            userService = new UserService(userRepository, userDisplayService);

            var userList = userService.GetData();
            var user = userService.GetDataById(15);

            userService.Display(userList);
            userService.Display(user);

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
