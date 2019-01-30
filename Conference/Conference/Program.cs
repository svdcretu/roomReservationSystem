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
            #region Listing
            ////Listing all the users
            //Console.WriteLine("Listing all the users:");
            //UserServices userServices = new UserServices();
            //List<User> userList = userServices.GetUsers();
            //foreach (User user in userList)
            //{
            //    PrintUsers.PrintUserData(user);
            //}
            //Console.WriteLine(" ");

            ////Listing the user with a certain id
            //int userId = 3;
            //Console.WriteLine($"Listing the user with id {userId}:");
            //User selectedUser = userServices.GetUser(userId);
            //PrintUsers.PrintUserData(selectedUser);
            //Console.WriteLine(" ");

            ////Listing all the rooms
            //RoomServices roomServices = new RoomServices();
            //List<ConferenceRoom> roomList = roomServices.GetRooms();
            //foreach (ConferenceRoom room in roomList)
            //{
            //    PrintRooms.PrintRoomDetails(room);
            //}
            //Console.WriteLine(" ");

            ////Listing the room with a certain id
            //int roomId = 1;
            //Console.WriteLine($"Listing the room with id {roomId}:");
            //try
            //{
            //    ConferenceRoom selectedRoom = roomServices.GetRoom(roomId);
            //    PrintRooms.PrintRoomDetails(selectedRoom);
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine(ex.Message);                
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine($"An unexpected exception was thrown: {e}");
            //}

            //Console.ReadLine();

            #endregion

            string printOption = GetPrintOptionFromUser();

            UserServices userServices = new UserServices();
            PrintUsers printUsers = new PrintUsers();
            List<User> userList = userServices.GetUsers();
            int userId = 1;
            User selectedUser = userServices.GetUser(userId);
            printUsers.Print(selectedUser, printOption);
            Console.ReadKey();



            string GetPrintOptionFromUser()
            {

                Dictionary<string, string> validOptions = new Dictionary<string, string>()
            {
             { "1", "Print to File"},
             { "2", "Print to Console" }
            };

                string userInput = "";
                bool invalidInput = true;
                while (!validOptions.Keys.Contains(userInput))
                {
                    Console.WriteLine("Please choose an option (1/2) and press Enter to apply:");
                    Console.WriteLine($"{validOptions.ElementAt(0).Key}:{validOptions.ElementAt(0).Value}");
                    Console.WriteLine($"{validOptions.ElementAt(1).Key}:{validOptions.ElementAt(1).Value}");

                    userInput = Console.ReadLine().Trim();
                    invalidInput = string.IsNullOrEmpty(userInput) || string.IsNullOrWhiteSpace(userInput) || !validOptions.Keys.Contains(userInput);

                    if (!invalidInput)
                    {
                        var chosenOption = validOptions.SingleOrDefault(x => x.Key == userInput);
                        userInput = chosenOption.Key;
                    }

                }
                return userInput;
            }

        }
    }
}
