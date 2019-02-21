using BusinesServices.Contracts;
using ConferenceModels;
using ConferenceUtils;
using System.Collections.Generic;

namespace BusinesServices.DisplayInfo
{
    public class DisplayUserServiceFile : IDisplayService<User>
    {
        public void Display(User user)
        {
            if (user != null)
            {
                string line = string.Format($"Id: {user.UserId}, Name: {user.Name}, Email: {user.Email}") + System.Environment.NewLine;
                Utils.PrintToFile(line);
            }

        }

        public void Display(IList<User> userList)
        {
            if (userList.Count > 0)
            {
                string usersToPrint = "";
                foreach (User user in userList)
                {
                    usersToPrint += string.Format($"Id: {user.UserId}, Name: {user.Name}, Email: {user.Email}") + System.Environment.NewLine;
                }
                if (!string.IsNullOrEmpty(usersToPrint))
                {
                    Utils.PrintToFile(usersToPrint);
                }
            }

        }
    }
}
