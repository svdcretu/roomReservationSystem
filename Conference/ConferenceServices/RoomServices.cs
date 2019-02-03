using System;
using System.Collections.Generic;
using System.Linq;
using ConferenceModels;


namespace ConferenceServices
{
    public class RoomServices
    {
        private string roomList;
        private Connect connection;

        public RoomServices()
        {
            connection = new Connect(ConnectionType.File);
        }

        public RoomServices(ConnectionType connectionType)
        {
            connection = new Connect(connectionType);
        }


        public string GetRooms(ConnectionType connectionType)
        {
            roomList = connection.RecordList;
            return roomList;

        }


        //public ConferenceRoom GetRoom(int roomId)
        //{
        //    ConferenceRoom result = null;
        //    try
        //    {
        //        roomList = connection.RecordList;
        //        result = roomList.SingleOrDefault(x => x.RoomId == roomId);                
        //    }
        //    catch (InvalidOperationException)
        //    {
        //        var myEx = new InvalidOperationException($"Room with id {roomId} is duplicated");
        //        throw myEx;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return result;
        //}



        //public string GetRoomAsString(int roomId)
        //{
        //    string result = "";
        //    List<ConferenceRoom> rooms;

        //    try
        //    {
        //        rooms = connection.RecordList;
        //        var room = roomList.SingleOrDefault(x => x.RoomId == roomId);
        //        result = String.Format($"Room Id: {room.RoomId}, Name: {room.Name}, Description: {room.Description}, Site: {room.Site}, Equipments: {string.Join(", ", room.EquipmentList.ToArray())}");
        //    }

        //    catch (InvalidOperationException)
        //    {
        //        Console.WriteLine($"There is no unique room with id: {roomId}.");
        //    }

        //    catch (NullReferenceException)
        //    {
        //        Console.WriteLine($"There is no room with id: {roomId}.");
        //    }
        //    return result;
        //}


    }
}
