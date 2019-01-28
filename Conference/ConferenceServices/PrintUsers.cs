using System;
using System.Collections.Generic;
using System.Text;
using ConferenceModels;

namespace ConferenceServices
{
    public class PrintUsers
    {
        public static void PrintUserData(User user)
        {
            if (user != null)
            {
                Console.WriteLine($"User Id: {user.UserId}, Name: {user.Name}, Email: {user.Email}");
            }
                
        }
    }
}
