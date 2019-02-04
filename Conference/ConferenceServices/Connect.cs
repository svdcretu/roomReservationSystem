using ConferenceRepos;
using System.Collections.Generic;

namespace ConferenceModels
{
    public class Connect
    {

        private RoomRepository roomRepository;
        public string RoomListAsString;
        public List<ConferenceRoom> RoomList;

        //By default returns List of ConferenceRoom
        public Connect()
        {
            roomRepository = new RoomRepository();
            RoomListAsString = roomRepository.GetRoomsFileListAsString();
            RoomList = roomRepository.GetRoomsHardcodedList();
        }

        public Connect(ConnectionType connectionType)
        {
            roomRepository = new RoomRepository();
            switch (connectionType)
            {
                case ConnectionType.File:
                    RoomListAsString = roomRepository.GetRoomsFileListAsString();
                    RoomList = roomRepository.GetRoomsFileList();
                    break;
                case ConnectionType.Hardcoded:
                default:
                    RoomListAsString = roomRepository.GetRoomsHardcodedListAsString();
                    RoomList = roomRepository.GetRoomsHardcodedList();
                    break;
            }
        }


    }
}
