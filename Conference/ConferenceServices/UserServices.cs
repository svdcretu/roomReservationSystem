using System;
using System.Collections.Generic;
using ConferenceModels;
using ConferenceRepos;


namespace ConferenceServices
{
    public class UserServices
    {
        private List<User> users;
        UserRepository userRepository;

        public UserServices()
        {
            userRepository = new UserRepository();
        }

        public List<User> GetUsers()
        {
            users = userRepository.GetUsers();
            return users;
        }

        public User GetUser(int userId)
        {
            users = userRepository.GetUsers();
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


    }
}
