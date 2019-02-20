using System;
using System.Collections.Generic;
using ConferenceRepository.Contracts;
using ConferenceModels;

namespace ConferenceRepository.UserRepository
{
    public class HardCodedUserRepository: IRepository<User>
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
