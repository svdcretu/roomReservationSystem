using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesServices.Contracts
{
    public interface IBusinesService<T>
    {
        /// <summary>
        /// Gets the list of all the data in system
        /// </summary>
        /// <returns>A list of T</returns>
        IList<T> GetData();

        /// <summary>
        /// Gets the data by id.
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>An data entity based on id. Returns null if not found, and exception if duplicate id's found.</returns>
        T GetDataById(int id);

        /// <summary>
        /// Display the data
        /// </summary>
        /// <param name="dataToDisplay">Data to display</param>
        void Display(T dataToDisplay);

        /// <summary>
        /// Display a list of data
        /// </summary>
        /// <param name="dataToDisplay">The list to be displayed</param>
        void Display(IList<T> dataToDisplay);
    }
}
