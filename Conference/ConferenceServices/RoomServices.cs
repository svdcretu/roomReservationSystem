using System.Collections.Generic;
using System.Linq;
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


        public ConferenceRoom GetRoom(int roomId)
        {
            roomList = roomRepository.GetRooms();
            ConferenceRoom result = roomList[0];

            IEnumerable<ConferenceRoom> room = roomList.Where(x => x.RoomId == roomId).ToList();
            //foreach (ConferenceRoom room in roomList)
            //{
            //    if (room.RoomId == roomId)
            //    {
            //        result = room;
            //        break;
            //    }
            //}
            return result;
        }

        }
}
