using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConferenceInterfaces;

namespace ConferenceServices
{
    public class GenericRepo : IGenericRepo
    {
        public List<IProcess> GetThingsToProcess()
        {
            List<IProcess> listToProcess = new List<IProcess>();
            RoomServices roomServices = new RoomServices();
            listToProcess.Add(roomServices);

            return listToProcess;
        }
    }
}
