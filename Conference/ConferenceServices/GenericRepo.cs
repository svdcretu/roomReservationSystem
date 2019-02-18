using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConferenceInterfaces;
using ConferenceModels;

namespace ConferenceServices
{
    public class GenericRepo : IGenericRepo
    {

        ConnectionType _connectionType;
        IProcess _entityService;

        public GenericRepo(ConnectionType connectionType, IProcess entityService)
        {
            _connectionType = connectionType;
            _entityService = entityService;
        }

        public string ConnectToRepo(ConnectionType connectionType)
        {
            String results = _entityService.Connect(connectionType);
            return results;
        }
    }
}
