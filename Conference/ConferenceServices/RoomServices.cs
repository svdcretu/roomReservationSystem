using System;
using System.Collections.Generic;
using System.Linq;
using ConferenceModels;


namespace ConferenceServices
{
    public class RoomServices
    {
        private string recordList;
        private List<ConferenceRoom> roomList;
        private Connect connection;

        public RoomServices()
        {
            connection = new Connect();
        }

        public RoomServices(ConnectionType connectionType)
        {
            connection = new Connect(connectionType);
        }


        public string GetRooms(ConnectionType connectionType)
        {
            recordList = connection.RecordList;
            return recordList;

        }



        public string GetRoomAsString(int roomId)
        {
            string result = "";
            ConferenceRoom room = null;

            try
            {
                roomList = connection.RoomList;
                room = roomList.SingleOrDefault(x => x.RoomId == roomId);
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
