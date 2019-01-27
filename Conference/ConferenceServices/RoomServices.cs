using System;
using System.Collections.Generic;
using System.Text;
using ConferenceModels;

namespace ConferenceServices
{
    public class RoomServices
    {
        List<ConferenceRoom> roomList;
        List<Equipment> equipmentList;

        public RoomServices()
        {
            roomList = new List<ConferenceRoom>();
            roomList.Add(
                new ConferenceRoom()
                { RoomId = 1, Name = "Manhattan", Floor = 1, MapUrl = "url1", Description = "Description1", Site = "Iasi", Latitude = 47.154614, Longitude = 27.579835, EquipmentList = new List<Equipment>() { Equipment.Jabra} });
            roomList.Add(
                  new ConferenceRoom() { RoomId = 2, Name = "Times Square", Floor = 1, MapUrl = "url2", Description = "Description2", Site = "Iasi", Latitude = 47.154614, Longitude = 27.579835, EquipmentList = new List<Equipment>() { Equipment.Laptop, Equipment.Monitor } });
        }


        public List<ConferenceRoom> GetRooms()
        {
            return roomList;
        }


        public void PrintRoomDetails(ConferenceRoom room)
        {
            Console.WriteLine($"Room Id: {room.RoomId}, Name: {room.Name}, Description: {room.Description}, Site: {room.Site}, Equipments: {string.Join(", ",room.EquipmentList.ToArray())}");
        }


    }
}
