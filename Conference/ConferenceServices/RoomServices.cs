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
                result = roomList.SingleOrDefault(x => x.RoomId == roomId);                
            }
            catch (InvalidOperationException)
            {
                var myEx = new InvalidOperationException($"Room with id {roomId} is duplicated");
                throw myEx;
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

    }
}
