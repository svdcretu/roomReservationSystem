using ConferenceRepos;
using System.Collections.Generic;

namespace ConferenceModels
{
    public class Connect
    {

        private RoomRepository roomRepository;
        public string RecordList;
        public List<ConferenceRoom> RoomList;

        //By default returns List of ConferenceRoom
        public Connect()
        {
            roomRepository = new RoomRepository();
            RoomList = roomRepository.GetRoomList();
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
