using System.Collections.Generic;
using BusinesServices.Contracts;

using ConferenceModels;

using ConferenceRepository.Contracts;

namespace BusinesServices.UserBusiness
{
    public class UserService: IBusinesService<User>
    {
        private readonly IRepository<User> _userRepository;
        private readonly IDisplayService<User> _displayService;

        public UserService(IRepository<User> userRepository, IDisplayService<User> displayService)
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

        public void Display(User dataToDisplay)
        {
            _displayService.Display(dataToDisplay);
        }

        public void Display(IList<User> dataToDisplay)
        {
            _displayService.Display(dataToDisplay);
        }
    }
}
