﻿using System;
using System.Collections.Generic;
using System.Linq;
using ConferenceModels;


namespace ConferenceServices
{
    public class RoomServices
    {
        private string roomListAsString;
        private List<ConferenceRoom> roomList;
        private Connect connection;

        public RoomServices()
        {
            connection = new Connect();
        }

        public RoomServices(ConnectionType connectionType)
        {
            connectionType = ConnectionType.File;
            connection = new Connect(connectionType);
            var s = connection.RoomListAsString;
            var list = connection.RoomList;
        }


        public string GetRoomsAsString(ConnectionType connectionType)
        {
            connectionType = ConnectionType.Hardcoded;
            connection.ConnectionType = connectionType;
            roomListAsString = connection.GetRoomsFileListAsString(connectionType);
            return roomListAsString;

        }



        public string GetRoomAsString(ConnectionType connectionType,int roomId)
        {
            string result = "";
            ConferenceRoom room = null;
            roomList = connection.RoomList;
            try
            {               
                room = roomList.SingleOrDefault(x => x.RoomId == roomId);
                result = String.Format($"Room Id: {room.RoomId}, Name: {room.Name}, Description: {room.Description}, Site: {room.Site} , Equipments: {string.Join(", ", room.EquipmentList.ToArray())}");
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
