using System;
using System.Collections.Generic;
using ConferenceInterfaces;
using ConferenceModels;
using ConferenceUtils;


namespace ConferenceServices
{
    public class UserServices : IProcess
    {
        private List<User> userList;
        private GenericRepo _userRepository;
        private string _userListAsString;


        public UserServices(ConnectionType connectionType)
        {
            _userRepository = new GenericRepo(connectionType, this);
            _userListAsString = _userRepository.ConnectToRepo(connectionType);

        }

        public string GetUsersHardcodedListAsString()
        {
            string res = "";
            List<User> userList = GetUsersHardcodedList();
            foreach (User user in userList)
            {
                res += String.Format($"Id: {user.UserId}, Name: {user.Name}, Email: {user.Email}") + System.Environment.NewLine;
            }
            return res;
        }

        public List<User> GetUsersHardcodedList()
        {
            userList = new List<User>();
            userList.Add(new User() { UserId = 0, Name = "Ana Popa Hardcoded", Email = "defaultemail@gmail.com" });
            userList.Add(new User() { UserId = 1, Name = "Vasile Popa Hardcoded", Email = "vasile.popa@gmail.com" });
            userList.Add(new User() { UserId = 2, Name = "Anca Marcu Hardcoded", Email = "ancamarcu@yahoo.com" });
            userList.Add(new User() { UserId = 3, Name = "Sorin Popovici Hardcoded", Email = "sorinp@gmail.com" });
            return userList;

        }

        public List<User> GetUserListFromFile()
        {
            List<User> userList = Utils.readTextFileToUserObject("UsersRepo.txt");
            return userList;
        }

        public string GetUsersFileListAsString()
        {
            string userListAsString = Utils.readTextFile("UsersRepo.txt");
            return userListAsString;

        }

        public string Connect(ConnectionType connectionType)
        {
            String UserListAsString;
            switch (connectionType)
            {
                case ConnectionType.File:
                    UserListAsString = GetUsersFileListAsString();
                    break;
                case ConnectionType.Hardcoded:
                default:
                    UserListAsString = GetUsersHardcodedListAsString();
                    break;
            }
            return UserListAsString;
        }

        public void Print(string destination)
        {
            PrintEntity.Print(_userListAsString, destination);
        }
    }
}
