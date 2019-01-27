using System.Collections.Generic;
using System.Net;

namespace ConferenceModels
{
    public class ConferenceRoom
    {

        public int RoomId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Floor { get; set; }
        public string MapUrl { get; set; }
        public string Site { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<Equipment> EquipmentList { get; set; }

        public ConferenceRoom()
        {
            EquipmentList = new List<Equipment>();
        }

    }
    
}
