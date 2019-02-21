using System;
using System.Collections.Generic;

using ConferenceModels;

namespace ConferenceRepository.UserRepository
{
    public class FileBaseUserRepository : AbstractUserRepository
    {
        public override IList<User> GetData()
        {
            throw new NotImplementedException();
        }

        public new User GetDataById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
