using System.Collections.Generic;

namespace BusinesServices.Contracts
{
    public interface IPrint<T>
    {
        void Print(T entity);
        void Print(IList<T> entityList);
    }
}
