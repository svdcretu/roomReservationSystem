using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConferenceServices;
using ConferenceModels;


namespace Conference
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of users
            UserServices userServices = new UserServices();
            List<User> userList = userServices.GetUsers();
            foreach (User user in userList)
            {
                userServices.PrintUserData(user);
            }

            //List the user with a certain id
            int i = 5;
            Console.WriteLine(" ");
            User selectedUser = userServices.GetUser(i);
            userServices.PrintUserData(selectedUser);

            RoomServices roomServices = new RoomServices();
            List<ConferenceRoom> roomList = roomServices.GetRooms();
            Console.WriteLine(" ");
            foreach (ConferenceRoom room in roomList)
            {
                roomServices.PrintRoomDetails(room);
            }


            Console.ReadLine();

        }
    }
}
