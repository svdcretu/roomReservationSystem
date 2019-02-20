using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinesServices.Contracts;

using ConferenceModels;

namespace BusinesServices.DisplyInfo
{
    public class DisplayUserService : IDisplayService<User>
    {
        public void Display(User dataToDisplay)
        {
            //Console.Writeline
            throw new NotImplementedException();
        }

        public void Display(IList<User> dataToDisplay)
        {
            //Console.Writeline
            throw new NotImplementedException();
        }
    }
}
