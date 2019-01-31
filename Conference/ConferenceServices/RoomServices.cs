using System;
using System.Collections.Generic;
using System.Linq;
using ConferenceModels;
using ConferenceRepos;

namespace ConferenceServices
{
    public class RoomServices
    {
        private List<ConferenceRoom> roomList;
        private RoomRepository roomRepository;


        public RoomServices()
        {
            roomRepository = new RoomRepository();
            roomList = roomRepository.Connect(ConnectionType.Hardcoded, "aaa");
        }


        public List<ConferenceRoom> GetRooms()
        {
            //roomList = roomRepository.GetRoomsHardcoded();
            //roomList = roomRepository.Connect(ConnectionType.Hardcoded, "aaa");
            return roomList;
        }


        public String GetRoomsAsString()
        {
            var res = "";
            //roomList = roomRepository.GetRoomsHardcoded();
            //roomList = roomRepository.Connect(ConnectionType.Hardcoded, "aaa");
            foreach (ConferenceRoom room in roomList)
            {
                res += String.Format($"Room Id: {room.RoomId}, Name: {room.Name}, Description: {room.Description}, Site: {room.Site}, Equipments: {string.Join(", ", room.EquipmentList.ToArray())}") + System.Environment.NewLine;
            }
            return res;
        }


        public ConferenceRoom GetRoom(int roomId)
        {
            ConferenceRoom result = null;
            try
            {
                //roomList = roomRepository.GetRoomsHardcoded();
                result = roomList.SingleOrDefault(x => x.RoomId == roomId);                
            }
            catch (InvalidOperationException)
            {
                var myEx = new InvalidOperationException($"Room with id {roomId} is duplicated");
                throw myEx;
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }



        public string GetRoomAsString(int roomId)
        {
            string result = "";

            try
            {
                //roomList = roomRepository.GetRoomsHardcoded();
                var room = roomList.SingleOrDefault(x => x.RoomId == roomId);
                result = String.Format($"Room Id: {room.RoomId}, Name: {room.Name}, Description: {room.Description}, Site: {room.Site}, Equipments: {string.Join(", ", room.EquipmentList.ToArray())}");
            }

            catch (InvalidOperationException)
            {
                Console.WriteLine($"There is no unique room with id: {roomId}.");
            }

            catch (NullReferenceException)
            {
                Console.WriteLine($"There is no room with id: {roomId}.");
            }
            return result;
        }


    }
}
