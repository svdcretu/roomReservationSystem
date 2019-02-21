using System.Collections.Generic;
using ConferenceModels;
using ConferenceUtils;

namespace ConferenceRepository.RoomRepository
{
    public class FileBaseRoomRepository : AbstractRoomRepository
    {
        public override IList<ConferenceRoom> GetData()
        {
            List<ConferenceRoom> roomList = Utils.readTextFileToConferenceRoomObject("RoomsRepo.txt");
            return roomList;
        }

        public new ConferenceRoom GetDataById(int id)
        {
            ConferenceRoom room = base.GetDataById(id);
            return room;
        }
    }
}
