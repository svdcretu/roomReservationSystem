using ConferenceRepos;
using System.Collections.Generic;

namespace ConferenceModels
{
    public class Connect
    {

        private RoomRepository roomRepository;        
        public List<ConferenceRoom> RoomList;
        public string RoomListAsString { get; private set; }
        public ConnectionType ConnectionType { get; set; }

        //By default returns List of ConferenceRoom
        public Connect()
        {
            roomRepository = new RoomRepository();
            RoomListAsString = roomRepository.GetRoomsFileListAsString();
            RoomList = roomRepository.GetRoomsHardcodedList();
        }

        public Connect(ConnectionType connectionType)
        {
            this.ConnectionType = connectionType;
            roomRepository = new RoomRepository();
            switch (this.ConnectionType)
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

        public string GetRoomsFileListAsString(ConnectionType connectionType)
        {
            string result;
            switch (connectionType)
            {
                case ConnectionType.File:
                    result = roomRepository.GetRoomsFileListAsString();
                    break;
                case ConnectionType.Hardcoded:
                default:
                    result = roomRepository.GetRoomsHardcodedListAsString();                    
                    break;
            }

            return result;
        }


    }
}
