using System;
using System.Collections.Generic;
using ConferenceModels;


namespace ConferenceServices
{
    public class UserServices
    {
        private List<User> users;

        public UserServices()
        {
            users = new List<User>();
            users.Add(new User() { UserId = 0, Name = "DefaultUser", Email = "defaultemail@gmail.com" });
            users.Add(new User() { UserId = 1, Name = "Vasile Popa", Email = "vasile.popa@gmail.com" });
            users.Add(new User() { UserId = 2, Name = "Anca Marcu", Email = "ancamarcu@yahoo.com" });
            users.Add(new User() { UserId = 3, Name = "Sorin Popovici", Email = "sorinp@gmail.com" });
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public User GetUser(int userId)
        {
            User result = users[0];
            foreach (User user in users)
            {
                if (user.UserId == userId)
                {
                    result = user;
                    break;
                }
            }
            return result;
        }

        public void PrintUserData(User user)
        {
            Console.WriteLine($"User Id: {user.UserId}, Name: {user.Name}, Email: {user.Email}");
        }

    }
}
