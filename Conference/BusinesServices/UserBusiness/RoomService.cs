using System.Collections.Generic;
using BusinesServices.Contracts;
using ConferenceModels;
using ConferenceRepository.Contracts;


namespace BusinesServices.UserBusiness
{
    public class RoomService : IPrint<ConferenceRoom>, IBusinesService<ConferenceRoom>
    {
        IRepository<ConferenceRoom> _repository;
        IPrint<ConferenceRoom> _displayService;

        public RoomService(IRepository<ConferenceRoom> repository, IPrint<ConferenceRoom> displayService)
        {
            _repository = repository;
            _displayService = displayService;
        }

        public IList<ConferenceRoom> GetData()
        {
            IList<ConferenceRoom> rooms = _repository.GetData();
            return rooms;
        }

        public ConferenceRoom GetDataById(int id)
        {
            ConferenceRoom room = _repository.GetDataById(id);
            return room;
        }

        public void Print(ConferenceRoom entity)
        {
            _displayService.Print(entity);
        }

        public void Print(IList<ConferenceRoom> entityList)
        {
            _displayService.Print(entityList);
        }
    }
}
