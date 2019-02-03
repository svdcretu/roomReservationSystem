using System;
using System.Collections.Generic;
using ConferenceModels;
using ConferenceRepos;
using System.Linq;


namespace ConferenceServices
{
    public class UserServices
    {
        private List<User> userList;
        UserRepository userRepository;

        public UserServices()
        {
            userRepository = new UserRepository();
        }

        public List<User> GetUsers()
        {
            userList = userRepository.GetUsers();
            return userList;
        }

        public String GetUsersAsString()
        {
            var res = "";
            userList = userRepository.GetUsers();
            foreach (User user in userList)
            {
                res += String.Format($"Id: {user.UserId}, Name: {user.Name}, Email: {user.Email}") + System.Environment.NewLine;
            }
            return res;
        }

        public User GetUser(int userId)
        {
            User result = null;
            try
            {
                userList = userRepository.GetUsers();
                result = userList.Where(x => x.UserId == userId).First();
            }

            catch (InvalidOperationException)
            {
                Console.WriteLine($"There is no user with id: {userId}.");
            }

            return result;
        }

        public string GetUserAsString(int userId)
        {
            string result = "";

            try
            {
                userList = userRepository.GetUsers();
                var user = userList.Single(x => x.UserId == userId);
                result = string.Format($"Id: {user.UserId}, Name: {user.Name}, Email: {user.Email}");
            }

            catch (InvalidOperationException)
            {
                Console.WriteLine($"There is no user with id: {userId}.");
            }
            return result;
        }




    }
}
