using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesServices.Contracts
{
    public interface IDisplayService<T>
    {
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
