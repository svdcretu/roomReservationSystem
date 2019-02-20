using System.Collections.Generic;

namespace ConferenceRepository.Contracts
{
    /// <summary>
    /// Repository contract
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
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
    }
}
