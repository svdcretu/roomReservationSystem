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
            //Listing all the users
            Console.WriteLine("Listing all the users:");
            UserServices userServices = new UserServices();
            List<User> userList = userServices.GetUsers();
            foreach (User user in userList)
            {
                PrintUsers.PrintUserData(user);
            }
            Console.WriteLine(" ");

            //Listing the user with a certain id
            int userId = 3;
            Console.WriteLine($"Listing the user with id {userId}:");
            User selectedUser = userServices.GetUser(userId);
            PrintUsers.PrintUserData(selectedUser);
            Console.WriteLine(" ");

            //Listing all the rooms
            RoomServices roomServices = new RoomServices();
            List<ConferenceRoom> roomList = roomServices.GetRooms();
            foreach (ConferenceRoom room in roomList)
            {
                PrintRooms.PrintRoomDetails(room);
            }
            Console.WriteLine(" ");

            //Listing the room with a certain id
            int roomId = 5;
            Console.WriteLine($"Listing the room with id {roomId}:");
            try
            {
                ConferenceRoom selectedRoom = roomServices.GetRoom(roomId);
                PrintRooms.PrintRoomDetails(selectedRoom);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);                
            }
            catch(Exception e)
            {
                Console.WriteLine($"An unexpected exception was thrown: {e}");
            }
            
            
            Console.ReadLine();

        }
    }
}
