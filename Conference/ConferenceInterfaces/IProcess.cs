using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConferenceModels;

namespace ConferenceInterfaces
{
    public interface IProcess
    {
        String Connect(ConnectionType connectionType);

        void PrintTo();
    }
}
