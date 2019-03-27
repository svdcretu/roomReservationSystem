using System.Collections.Generic;
using BusinesServices.Contracts;

using ConferenceModels;

using ConferenceRepository.Contracts;

namespace BusinesServices.UserBusiness
{
    public class UserService : IPrint<User>, IBusinesService<User>
    {
        private readonly IRepository<User> _userRepository;
        IPrint<User> _displayService;

        public UserService(IRepository<User> userRepository, IPrint<User> displayService)
        {
            _userRepository = userRepository;
            _displayService = displayService;
        }

        public IList<User> GetData()
        {
            IList<User> data = _userRepository.GetData();
            return data;
        }

        public User GetDataById(int id)
        {
            User data = _userRepository.GetDataById(id);
            return data;
        }


        public void Print(User entity)
        {
            _displayService.Print(entity);
        }

        public void Print(IList<User> entityList)
        {
            _displayService.Print(entityList);
        }


    }
}
