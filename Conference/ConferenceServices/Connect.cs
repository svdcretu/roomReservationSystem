using System.Collections.Generic;
using ConferenceRepos;

namespace ConferenceModels
{
    public class Connect
    {

        private RoomRepository roomRepository;
        public List<ConferenceRoom> RecordList;

        //By default takes hardcoded repository
        public Connect()
        {
            roomRepository = new RoomRepository();
            RecordList = roomRepository.GetRoomsHardcodedRepo();
        }


        public Connect(ConnectionType connectionType)
        {
            roomRepository = new RoomRepository();
            switch (connectionType)
            {
                case ConnectionType.File:
                    RecordList = roomRepository.GetRoomsFileRepo();
                    break;
                case ConnectionType.Hardcoded:
                default:
                    RecordList = roomRepository.GetRoomsHardcodedRepo();
                    break;
            }
        }
    }
}
