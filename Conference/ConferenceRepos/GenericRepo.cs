using ConferenceInterfaces;
using ConferenceModels;
using System;

namespace ConferenceRepos
{
    public class GenericRepo : IGenericRepo
    {

        private ConnectionType _connectionType;
        private IProcess _entityService;

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
