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


    }
}
