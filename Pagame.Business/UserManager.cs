using System;
using System.Collections.Generic;
using Pagame.Business.Interfaces;
using Pagame.Entities;
using Pagame.Repository.Interfaces;

namespace Pagame.Business
{
    public class UserManager : IUserManager
    {
        private IUserRepository _userRepository;

        public bool AddUser(User user)
        {
            return _userRepository.AddUser(user);
        }

        public bool DeleteUser(int userId)
        {
            return _userRepository.DeleteUser(userId);
        }

        public IList<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public User GetUserByUserId(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public User GetUserByUserName(string userName)
        {
            return _userRepository.GetUserByUsername(userName);
        }

        public bool UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }
    }
}
