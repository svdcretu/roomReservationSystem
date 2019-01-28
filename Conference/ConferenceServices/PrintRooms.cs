using System;
using System.Collections.Generic;
using System.Text;
using ConferenceModels;

namespace ConferenceServices
{
    public class PrintRooms
    {
        public static void PrintRoomDetails(ConferenceRoom room)
        {
            if (room != null)
            {
                Console.WriteLine($"Room Id: {room.RoomId}, Name: {room.Name}, Description: {room.Description}, Site: {room.Site}, Equipments: {string.Join(", ", room.EquipmentList.ToArray())}");
            }
           
        }

    }
}
