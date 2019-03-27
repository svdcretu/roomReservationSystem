using System;
using System.Collections.Generic;
using ConferenceModels;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesServices.Contracts
{
    public interface IPrint<T> 
    {
        void Print(T entity);
        void Print(IList<T> entityList);
    }
}
