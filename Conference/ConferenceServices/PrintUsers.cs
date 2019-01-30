using System;
using System.Collections.Generic;
using System.Text;
using ConferenceModels;
using ConferenceUtils;


namespace ConferenceServices
{
    public class PrintUsers
    {


        public static void PrintUserData(User user)
        {

            if (user != null)
            {
                Console.WriteLine(user);
            }

        }

        public void Print(User user, string destination)
        {
            string userSerialized = $"User Id: {user.UserId}, Name: {user.Name}, Email: {user.Email}";
            switch (destination)
            {
                case "1":
                    PrintUtils.PrintToFile(userSerialized);
                    break;
                case "2":                 
                default:
                    Console.WriteLine(userSerialized);
                    break;
            }
        }


    }
}
