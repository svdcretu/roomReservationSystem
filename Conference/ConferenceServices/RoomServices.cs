using System;
using System.Collections.Generic;
using System.Linq;
using ConferenceModels;
using ConferenceInterfaces;
using ConferenceRepos;


namespace ConferenceServices
{
    public class RoomServices : IProcess
    {
        private string roomListAsString;
        private List<ConferenceRoom> roomList;
        private Connect connection;
        RoomRepository _roomRepository;

        //public RoomServices()
        //{
        //    connection = new Connect();
        //}

        public RoomServices(ConnectionType connectionType)
        {
            _roomRepository = new RoomRepository(connectionType);

        }


        //public string GetRoomsAsString(ConnectionType connectionType)
        //{
        //    roomListAsString = connection.RoomListAsString;
        //    return roomListAsString;

        //}

        //public string GetRoomAsString(ConnectionType connectionType,int roomId)
        //{
        //    string result = "";
        //    ConferenceRoom room = null;
        //    roomList = connection.RoomList;
        //    try
        //    {               
        //        room = roomList.SingleOrDefault(x => x.RoomId == roomId);
        //        result = String.Format($"Room Id: {room.RoomId}, Name: {room.Name}, Description: {room.Description}, Site: {room.Site} , Equipments: {string.Join(", ", room.EquipmentList.ToArray())}");
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


        public void PrintTo()
        {
            throw new NotImplementedException();
        }

        public void Connect(ConnectionType connectionType)
        {
            throw new NotImplementedException();
        }

        string IProcess.Connect(ConnectionType connectionType)
        {
            throw new NotImplementedException();
        }
    }
}
