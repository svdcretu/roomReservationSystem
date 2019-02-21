using System.Collections.Generic;
using ConferenceModels;

namespace ConferenceRepository.RoomRepository
{
    public class HardcodedRoomRepository : AbstractRoomRepository
    {

        public override IList<ConferenceRoom> GetData()
        {
            IList<ConferenceRoom> roomList = new List<ConferenceRoom>();
            List<Equipment> equipmentList = new List<Equipment>();
            roomList.Add(
                new ConferenceRoom()
                { RoomId = 1, Name = "Manhattan Hardcoded", Floor = 1, MapUrl = "url1", Description = "Manhattan", Site = "Iasi", Latitude = 47.154614, Longitude = 27.579835, EquipmentList = new List<Equipment>() { Equipment.Jabra } });
            roomList.Add(
                  new ConferenceRoom() { RoomId = 2, Name = "Times Square Hardcoded", Floor = 1, MapUrl = "url2", Description = "Times Square", Site = "Iasi", Latitude = 47.154614, Longitude = 27.579835, EquipmentList = new List<Equipment>() { Equipment.Laptop, Equipment.Monitor } });
            roomList.Add(
                new ConferenceRoom()
                { RoomId = 1, Name = "Rockefeller Hardcoded", Floor = 1, MapUrl = "url3", Description = "Rockefeller", Site = "Iasi", Latitude = 47.154614, Longitude = 27.579835, EquipmentList = new List<Equipment>() { Equipment.Jabra } });

            return roomList;
        }

        public new ConferenceRoom GetDataById(int id)
        {
            ConferenceRoom room = base.GetDataById(id);
            return room;
        }
    }
}
