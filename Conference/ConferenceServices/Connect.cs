using ConferenceRepos;
using System.Collections.Generic;
using ConferenceInterfaces;

namespace ConferenceModels
{
    public class Connect
    {

        private IProcess _process;

        //By default returns List of ConferenceRoom
        public Connect()
        {
        }

        public Connect(ConnectionType connectionType)
        {
            _process.Connect(connectionType);

        }


    }
}
