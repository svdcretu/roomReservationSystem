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
                Utils.PrintToFile(user.GetDescription);
            }

        }

        public void Display(IList<User> userList)
        {
            if (userList.Count > 0)
            {
                string usersToPrint = "";
                foreach (User user in userList)
                {
                    usersToPrint += user.GetDescription;
                }
                if (!string.IsNullOrEmpty(usersToPrint))
                {
                    Utils.PrintToFile(usersToPrint);
                }
            }

        }
    }
}
