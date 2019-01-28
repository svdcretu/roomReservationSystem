using System;
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
            ConferenceRoom result = null;
            try
            {
                roomList = roomRepository.GetRooms();
                result = roomList.Where(x => x.RoomId == roomId).Single();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine($"There should be only one room with id: {roomId}.");
            }
            return result;
        }

    }
}
