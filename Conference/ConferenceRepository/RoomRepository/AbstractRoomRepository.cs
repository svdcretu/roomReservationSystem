using System;
using System.Collections.Generic;
using System.Linq;
using ConferenceModels;
using ConferenceRepository.Contracts;

namespace ConferenceRepository.RoomRepository
{
    public abstract class AbstractRoomRepository : IRepository<ConferenceRoom>
    {
        public abstract IList<ConferenceRoom> GetData();

        public ConferenceRoom GetDataById(int id)
        {
            IList<ConferenceRoom> roomList = GetData();
            List<Equipment> equipmentList = new List<Equipment>();
            ConferenceRoom room = null;
            try
            {
                room = roomList.Single(x => x.RoomId == id);
            }

            catch (InvalidOperationException)
            {
                Console.WriteLine($"There is no unique room with id: {id}.");
            }

            catch (NullReferenceException)
            {
                Console.WriteLine($"There is no room with id: {id}.");
            }
            return room;
        }
    }
}
