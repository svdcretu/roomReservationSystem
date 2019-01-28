using System;
using System.Collections.Generic;
using System.Text;
using ConferenceModels;


namespace ConferenceRepos
{
    public class UserRepository
    {

        private List<User> userList;
        public List<User> GetUsers()
        {
            userList = new List<User>();
            userList.Add(new User() { UserId = 0, Name = "DefaultUser", Email = "defaultemail@gmail.com" });
            userList.Add(new User() { UserId = 1, Name = "Vasile Popa", Email = "vasile.popa@gmail.com" });
            userList.Add(new User() { UserId = 2, Name = "Anca Marcu", Email = "ancamarcu@yahoo.com" });
            userList.Add(new User() { UserId = 3, Name = "Sorin Popovici", Email = "sorinp@gmail.com" });

            return userList;
        }
    }
}
