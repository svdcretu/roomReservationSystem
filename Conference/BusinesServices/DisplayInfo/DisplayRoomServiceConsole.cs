using BusinesServices.Contracts;
using ConferenceModels;
using System;
using System.Collections.Generic;

namespace BusinesServices.DisplayInfo
{
    public class DisplayRoomServiceConsole : IDisplayService<ConferenceRoom>
    {
        public void Display(ConferenceRoom room)
        {
            if (room != null)
            {
                Console.WriteLine("--- Printing Room ---");
                Console.WriteLine(String.Format($"Room Id: {room.Id}, Name: {room.Name}, Description: {room.Description}, Site: {room.Site}, Equipments: {string.Join(", ", room.EquipmentList.ToArray())}"));
                Console.WriteLine("--- End Printing Room ---");
            }
        }

        public void Display(IList<ConferenceRoom> roomList)
        {
            if (roomList.Count > 0)
            {
                Console.WriteLine("--- Printing Room List ---");
                foreach (ConferenceRoom room in roomList)
                {
                    Console.WriteLine(String.Format($"Room Id: {room.Id}, Name: {room.Name}, Description: {room.Description}, Site: {room.Site}, Equipments: {string.Join(", ", room.EquipmentList.ToArray())}"));
                }
                Console.WriteLine("--- End Printing Room List ---");
            }

        }
    }
}
