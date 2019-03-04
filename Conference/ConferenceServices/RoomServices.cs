using ConferenceInterfaces;
using ConferenceModels;
using ConferenceRepos;
using ConferenceUtils;
using System;
using System.Collections.Generic;


namespace ConferenceServices
{
    public class RoomServices : IProcess
    {

        private List<ConferenceRoom> roomList;
        private GenericRepo _roomRepository;
        private List<Equipment> equipmentList;
        private string _roomListAsString;



        public RoomServices(ConnectionType connectionType)
        {
            _roomRepository = new GenericRepo(connectionType, this);
            _roomListAsString = _roomRepository.ConnectToRepo(connectionType);

        }


        public String Connect(ConnectionType connectionType)
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

        public List<ConferenceRoom> GetRoomsListHardcoded()
        {
            roomList = new List<ConferenceRoom>();
            equipmentList = new List<Equipment>();
            roomList.Add(
                new ConferenceRoom()
                { Id = 1, Name = "Manhattan Hardcoded", Floor = 1, MapUrl = "url1", Description = "Manhattan", Site = "Iasi", Latitude = 47.154614, Longitude = 27.579835, EquipmentList = new List<Equipment>() { Equipment.Jabra } });
            roomList.Add(
                  new ConferenceRoom() { Id = 2, Name = "Times Square Hardcoded", Floor = 1, MapUrl = "url2", Description = "Times Square", Site = "Iasi", Latitude = 47.154614, Longitude = 27.579835, EquipmentList = new List<Equipment>() { Equipment.Laptop, Equipment.Monitor } });
            roomList.Add(
                new ConferenceRoom()
                { Id = 1, Name = "Rockefeller Hardcoded", Floor = 1, MapUrl = "url3", Description = "Rockefeller", Site = "Iasi", Latitude = 47.154614, Longitude = 27.579835, EquipmentList = new List<Equipment>() { Equipment.Jabra } });

            return roomList;
        }

        public string GetRoomsHardcodedListAsString()
        {
            var res = "";
            roomList = GetRoomsListHardcoded();
            foreach (ConferenceRoom room in roomList)
            {
                res += String.Format($"Room Id: {room.Id}, Name: {room.Name}, Description: {room.Description}, Site: {room.Site}, Equipments: {string.Join(", ", room.EquipmentList.ToArray())}") + System.Environment.NewLine;
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

        public void Print(string destination)
        {
            PrintEntity.Print(_roomListAsString, destination);
        }
    }
}
