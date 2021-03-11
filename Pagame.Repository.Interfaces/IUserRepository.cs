using System;
using System.Collections.Generic;
using Pagame.Entities;
namespace Pagame.Repository.Interfaces
{
    public interface IUserRepository
    {
        public bool AddUser(User user);
        public bool UpdateUser(User user);
        public bool DeleteUser(int id);
        public IList<User> GetAllUsers();
        public User GetUserByUsername(string username);
        public User GetUserById(int userId);


    }
}
