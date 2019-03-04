using System.Collections.Generic;
using System.Linq;

using ConferenceModels;

using ConferenceRepository.Contracts;

namespace ConferenceRepository
{
    public abstract class AbstractRepository<T> : IRepository<T> where T: IConferenceModel
    {
        public abstract IList<T> GetData();

        public virtual T GetDataById(int id)
        {
            IList<T> dataSet = GetData();

            T value = dataSet.SingleOrDefault(x => x.Id == id);

            return value;
        }
    }
}
