using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConferenceModels;

namespace ConferenceInterfaces
{
    public interface IGenericRepo
    {
        String ConnectToRepo(ConnectionType connectionType);
    }
}
