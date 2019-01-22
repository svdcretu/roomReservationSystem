using System.Collections.Generic;
using System.Net;

namespace ConferenceModels
{
    public class ConferenceRoom
    {
		private readonly int _roomId;

        public int RoomId { get { return _roomId; } }
		public string Name { get; set; }
        public string Description { get; set; }
        public int Floor { get; set; }
        public string MapUrl { get; set; }
        public string Site { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<Equipment> EquipmentList { get; set; }
		
        public ConferenceRoom(int roomId)
        {
			_roomId = roomId;
            EquipmentList = new List<Equipment>();
        }
    }
}
