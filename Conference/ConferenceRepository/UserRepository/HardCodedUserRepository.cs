using System.Collections.Generic;
using ConferenceModels;

namespace ConferenceRepository.UserRepository
{
    public class HardCodedUserRepository : AbstractUserRepository
    {
        public override IList<User> GetData()
        {
            IList<User> userList = new List<User>();
            userList.Add(new User() { UserId = 0, Name = "DefaultUser", Email = "defaultemail@gmail.com" });
            userList.Add(new User() { UserId = 1, Name = "Vasile Popa", Email = "vasile.popa@gmail.com" });
            userList.Add(new User() { UserId = 2, Name = "Anca Marcu", Email = "ancamarcu@yahoo.com" });
            userList.Add(new User() { UserId = 3, Name = "Sorin Popovici", Email = "sorinp@gmail.com" });
            return userList;
        }

        public new User GetDataById(int id)
        {
            User user = base.GetDataById(id);
            return user;
        }
    }
}
