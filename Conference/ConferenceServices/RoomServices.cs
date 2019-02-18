﻿using System;
using System.Collections.Generic;
using ConferenceInterfaces;
using ConferenceModels;
using ConferenceRepos;
using ConferenceUtils;


namespace ConferenceServices
{
    public class RoomServices : IProcess
    {

        private List<ConferenceRoom> roomList;
        RoomRepository _roomRepository;
        private List<Equipment> equipmentList;



        public RoomServices(ConnectionType connectionType)
        {
            _roomRepository = new RoomRepository(connectionType, this);
            _roomRepository.ConnectToRepo(connectionType);

        }

        public void PrintTo()
        {
            throw new NotImplementedException();
        }

        public String Connect(ConnectionType connectionType)
        {
            {
                String RoomListAsString;
                switch (connectionType)
                {
                    case ConnectionType.File:
                        RoomListAsString = GetRoomsFileListAsString();
                        break;
                    case ConnectionType.Hardcoded:
                    default:
                        RoomListAsString = GetRoomsHardcodedListAsString();
                        break;
                }
                return RoomListAsString;
            }
        }


        public List<ConferenceRoom> GetRoomsListHardcoded()
        {
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

            return roomList;
        }

        public string GetRoomsHardcodedListAsString()
        {
            var res = "";
            roomList = GetRoomsListHardcoded();
            foreach (ConferenceRoom room in roomList)
            {
                res += String.Format($"Room Id: {room.RoomId}, Name: {room.Name}, Description: {room.Description}, Site: {room.Site}, Equipments: {string.Join(", ", room.EquipmentList.ToArray())}") + System.Environment.NewLine;
            }
            return res;
        }

        public string GetRoomsFileListAsString()
        {
            string roomListAsString = Utils.readTextFile("RoomsRepo.txt");
            return roomListAsString;
        }


        public List<ConferenceRoom> GetRoomsListFromFile()
        {
            roomList = Utils.readTextFileToConferenceRoomObject("RoomsRepo.txt");
            return roomList;
        }

    }
}
