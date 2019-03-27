using System.Collections.Generic;
using BusinesServices.Contracts;
using ConferenceModels;
using ConferenceRepository.Contracts;


namespace BusinesServices.UserBusiness
{
    public class RoomService : IBusinesService<ConferenceRoom>, IPrint<ConferenceRoom>
    {
        IRepository<ConferenceRoom> _repository;
        IDisplayService<ConferenceRoom> _displayService;

        //public RoomService(IRepository<ConferenceRoom> repository, IDisplayService<ConferenceRoom> displayService)
        //{
        //    _repository = repository;
        //    _displayService = displayService;
        //}

        public RoomService(IRepository<ConferenceRoom> repository, IDisplayService<ConferenceRoom> displayService)
        {
            _repository = repository;
            _displayService = displayService;
        }

        public void Display(ConferenceRoom dataToDisplay)
        {
            _displayService.Display(dataToDisplay);
        }

        public void Display(IList<ConferenceRoom> dataToDisplay)
        {
            _displayService.Display(dataToDisplay);
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
            throw new System.NotImplementedException();
        }

        public void Print(List<ConferenceRoom> entityList)
        {
            throw new System.NotImplementedException();
        }
    }
}
