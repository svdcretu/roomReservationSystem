using ConferenceModels;
using System;
using System.Collections.Generic;

namespace BusinesServices.Contracts
{
    public class PrintToConsole<T> : IPrint<T> where T : IConferenceModel
    {
        public virtual void Print(T entity)
        {
            Console.WriteLine(entity.GetDescription);
        }

        public virtual void Print(IList<T> entityList)
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
