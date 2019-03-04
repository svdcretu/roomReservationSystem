using System.Collections.Generic;
using ConferenceModels;
using ConferenceUtils;

namespace ConferenceRepository.UserRepository
{
    public class FileBaseUserRepository : AbstractRepository<User>
    {
        public override IList<User> GetData()
        {
            List<User> userList = Utils.readTextFileToUserObject("UsersRepo.txt");
            return userList;
        }
    }
}
