using System;
using System.Collections.Generic;
using ConferenceModels;
using ConferenceUtils;

namespace ConferenceRepos
{
    public class RoomRepository
    {
        private List<ConferenceRoom> roomList;
        private List<Equipment> equipmentList;


        public string GetRoomsHardcodedRepo()
        {
            var res = "";
            roomList = new List<ConferenceRoom>();
            equipmentList = new List<Equipment>();
            roomList.Add(
                new ConferenceRoom()
                { RoomId = 1, Name = "Manhattan Hardcoded", Floor = 1, MapUrl = "url1", Description = "Manhattan", Site = "Iasi", Latitude = 47.154614, Longitude = 27.579835, EquipmentList = new List<Equipment>() { Equipment.Jabra } });
            roomList.Add(
                  new ConferenceRoom() { RoomId = 2, Name = "Times Square Hardcoded", Floor = 1, MapUrl = "url2", Description = "Times Square", Site = "Iasi", Latitude = 47.154614, Longitude = 27.579835, EquipmentList = new List<Equipment>() { Equipment.Laptop, Equipment.Monitor } });
            roomList.Add(
                new ConferenceRoom()
                { RoomId = 1, Name = "Rockefeller Hardcoded", Floor = 1, MapUrl = "url3", Description = "Rockefeller", Site = "Iasi", Latitude = 47.154614, Longitude = 27.579835, EquipmentList = new List<Equipment>() { Equipment.Jabra } });

            foreach (ConferenceRoom room in roomList)
            {
                res += String.Format($"Room Id: {room.RoomId}, Name: {room.Name}, Description: {room.Description}, Site: {room.Site}, Equipments: {string.Join(", ", room.EquipmentList.ToArray())}") + System.Environment.NewLine;
            }
            return res;
        }

        public string GetRoomsFileRepo()
        {
            string roomList = Utils.readTextFile("RoomsRepo.txt");
            return roomList;
        }

    }
}
