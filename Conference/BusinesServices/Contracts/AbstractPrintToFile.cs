using ConferenceModels;
using ConferenceUtils;
using System.Collections.Generic;

namespace BusinesServices.Contracts
{
    public abstract class AbstractPrintToFile<T> : IPrint<T> where T : IConferenceModel
    {
        public void Print(T entity)
        {
            Utils.PrintToFile(entity.GetDescription);
        }

        public void Print(List<T> entityList)
        {
            if (entityList.Count > 0)
            {
                string roomsToPrint = "";
                foreach (IConferenceModel entity in entityList)
                {
                    roomsToPrint += entity.GetDescription;
                }
                Utils.PrintToFile(roomsToPrint);
            }
        }
    }
}
