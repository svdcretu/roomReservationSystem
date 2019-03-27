using ConferenceModels;
using ConferenceUtils;
using System;
using System.Collections.Generic;

namespace BusinesServices.Contracts
{
    public abstract class AbstractPrintToConsole<T> : IPrint<T> where T : IConferenceModel
    {
        public void Print(T entity)
        {
            Utils.PrintToFile(entity.GetDescription);
        }

        public void Print(List<T> entityList)
        {
            if (entityList.Count > 0)
            {
                Console.WriteLine("--- Printing Entity List ---");
                foreach (IConferenceModel entity in entityList)
                {
                    Console.WriteLine(entity.GetDescription);
                }
                Console.WriteLine("--- End Printing Entity List ---");
            }
        }
    }
}
