using System;
using System.Collections.Generic;
using Pagame.Entities;

namespace Pagame.Business.Interfaces
{
    public interface IUserManager
    {
        bool AddUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int userId);
        IList<User> GetAllUsers();
        User GetUserByUserName(string userName);
        User GetUserByUserId(int id);

    }
}
