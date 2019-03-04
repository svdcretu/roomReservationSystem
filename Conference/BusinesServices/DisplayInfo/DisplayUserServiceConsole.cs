using BusinesServices.Contracts;
using ConferenceModels;
using System;
using System.Collections.Generic;

namespace BusinesServices.DisplayInfo
{
    public class DisplayUserServiceConsole : IDisplayService<User>
    {
        public void Display(User user)
        {
            if (user != null)
            {
                Console.WriteLine("--- Printing User ---");
                Console.WriteLine(String.Format($"Id: {user.Id}, Name: {user.Name}, Email: {user.Email}"));
                Console.WriteLine("--- End Printing User ---");
            }

        }

        public void Display(IList<User> userList)
        {
            if (userList.Count > 0)
            {
                Console.WriteLine("--- Printing User List ---");
                foreach (User user in userList)
                {
                    Console.WriteLine(String.Format($"Id: {user.Id}, Name: {user.Name}, Email: {user.Email}"));
                }
                Console.WriteLine("--- End Printing User List ---");
            }

        }
    }
}
