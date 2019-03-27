using BusinesServices.Contracts;
using ConferenceModels;
using ConferenceUtils;
using System.Collections.Generic;

namespace BusinesServices.DisplayInfo
{
    public class DisplayRoomServiceFile 
    //IDisplayService<ConferenceRoom>

    {

        public void PrintToFile(ConferenceRoom room)
        {
            if (room != null)
            {
                Utils.PrintToFile(room.GetDescription);
            }
        }

        public void PrintToFile(IList<ConferenceRoom> roomList)
        {


            if (roomList.Count > 0)
            {
                string roomsToPrint = "";
                foreach (ConferenceRoom room in roomList)
                {
                    roomsToPrint += room.GetDescription;
                }
                Utils.PrintToFile(roomsToPrint);
            }

        }
    }
}
