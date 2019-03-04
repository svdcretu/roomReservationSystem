using System.Collections.Generic;
using ConferenceModels;
using ConferenceUtils;

namespace ConferenceRepository.RoomRepository
{
    public class FileBaseRoomRepository : AbstractRepository<ConferenceRoom>
    {
        public override IList<ConferenceRoom> GetData()
        {
            List<ConferenceRoom> roomList = Utils.readTextFileToConferenceRoomObject("RoomsRepo.txt");
            return roomList;
        }
    }
}
