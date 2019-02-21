using System.Collections.Generic;
using ConferenceModels;
using ConferenceUtils;

namespace ConferenceRepository.UserRepository
{
    public class FileBaseUserRepository : AbstractUserRepository
    {
        public override IList<User> GetData()
        {
            List<User> userList = Utils.readTextFileToUserObject("UsersRepo.txt");
            return userList;
        }

        public new User GetDataById(int id)
        {
            User user = base.GetDataById(id);
            return user;
        }
    }
}
