using System;
using System.Collections.Generic;
using System.Text;
//using ConferenceModels;

namespace ConferenceInterfaces
{
    public interface IPrintRoom
    {
        void Print(string text, string destination);
        //void Print(User user, string destination);
    }
}
