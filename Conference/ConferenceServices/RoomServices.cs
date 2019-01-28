using System.Collections.Generic;
using ConferenceModels;
using ConferenceRepos;

namespace ConferenceServices
{
    public class RoomServices
    {
        private List<ConferenceRoom> roomList;
        private RoomRepository roomRepository;


        public RoomServices()
        {
            roomRepository = new RoomRepository();
              }


        public List<ConferenceRoom> GetRooms()
        {
            roomList = roomRepository.GetRooms();
            return roomList;
        }

     


    }
}
