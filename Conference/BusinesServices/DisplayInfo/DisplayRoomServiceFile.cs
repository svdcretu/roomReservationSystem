using BusinesServices.Contracts;
using ConferenceModels;
using ConferenceUtils;
using System.Collections.Generic;

namespace BusinesServices.DisplayInfo
{
    public class DisplayRoomServiceFile : IDisplayService<ConferenceRoom>
    {
        public void Display(ConferenceRoom room)
        {
            if (room != null)
            {
                string line = string.Format($"Room Id: {room.Id}, Name: {room.Name}, Description: {room.Description}, Site: {room.Site}, Equipments: {string.Join(", ", room.EquipmentList.ToArray())}") + System.Environment.NewLine;
                Utils.PrintToFile(line);
            }
        }

        public void Display(IList<ConferenceRoom> roomList)
        {
            if (roomList.Count > 0)
            {
                string roomsToPrint = "";
                foreach (ConferenceRoom room in roomList)
                {
                    roomsToPrint += string.Format($"Room Id: {room.Id}, Name: {room.Name}, Description: {room.Description}, Site: {room.Site}, Equipments: {string.Join(", ", room.EquipmentList.ToArray())}") + System.Environment.NewLine;
                }
                Utils.PrintToFile(roomsToPrint);
            }

        }
    }
}
