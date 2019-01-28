using System;
using System.Collections.Generic;
using ConferenceModels;

namespace ConferenceRepos
{
    public class RoomRepository
    {
        private List<ConferenceRoom> roomList;
        private List<Equipment> equipmentList;

        public List<ConferenceRoom> GetRooms()
        {
            roomList = new List<ConferenceRoom>();
            equipmentList = new List<Equipment>();
            roomList.Add(
                new ConferenceRoom()
                { RoomId = 1, Name = "Manhattan", Floor = 1, MapUrl = "url1", Description = "Manhattan", Site = "Iasi", Latitude = 47.154614, Longitude = 27.579835, EquipmentList = new List<Equipment>() { Equipment.Jabra } });
            roomList.Add(
                  new ConferenceRoom() { RoomId = 2, Name = "Times Square", Floor = 1, MapUrl = "url2", Description = "Times Square", Site = "Iasi", Latitude = 47.154614, Longitude = 27.579835, EquipmentList = new List<Equipment>() { Equipment.Laptop, Equipment.Monitor } });
            roomList.Add(
                new ConferenceRoom()
                { RoomId = 1, Name = "Rockefeller", Floor = 1, MapUrl = "url3", Description = "Rockefeller", Site = "Iasi", Latitude = 47.154614, Longitude = 27.579835, EquipmentList = new List<Equipment>() { Equipment.Jabra } });

            return roomList;
        }
    }
}
