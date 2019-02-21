using System;
using System.Collections.Generic;
using System.Linq;
using ConferenceModels;
using ConferenceRepository.Contracts;

namespace ConferenceRepository.UserRepository
{
    public abstract class AbstractUserRepository : IRepository<User>
    {
        public abstract IList<User> GetData();

        public User GetDataById(int id)
        {
            IList<User> userList = GetData();
            User user = null;
            try
            {
                user = userList.Single(x => x.UserId == id);
            }

            catch (InvalidOperationException)
            {
                Console.WriteLine($"There is no unique user with id: {id}.");
            }

            catch (NullReferenceException)
            {
                Console.WriteLine($"There is no user with id: {id}.");
            }
            return user;
        }
    }
}
