using System.Collections.Generic;
using ConferenceModels;

namespace ConferenceRepository.UserRepository
{
    public class HardCodedUserRepository : AbstractRepository<User>
    {
        public override IList<User> GetData()
        {
            IList<User> userList = new List<User>();
            userList.Add(new User{ Id = 0, Name = "DefaultUser Hardcoded", Email = "defaultemail@gmail.com" });
            userList.Add(new User{ Id = 1, Name = "Vasile Popa Hardcoded", Email = "vasile.popa@gmail.com" });
            userList.Add(new User{ Id = 2, Name = "Anca Marcu Hardcoded", Email = "ancamarcu@yahoo.com" });
            userList.Add(new User{ Id = 3, Name = "Sorin Popovici Hardcoded", Email = "sorinp@gmail.com" });
            return userList;
        }
    }
}
