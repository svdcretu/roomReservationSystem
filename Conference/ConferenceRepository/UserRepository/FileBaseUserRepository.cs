using System;
using System.Collections.Generic;

using ConferenceModels;

using ConferenceRepository.Contracts;

namespace ConferenceRepository.UserRepository
{
    public class FileBaseUserRepository: IRepository<User>
    {
        public IList<User> GetData()
        {
            throw new NotImplementedException();
        }

        public User GetDataById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
