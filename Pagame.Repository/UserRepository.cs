using System;
using Dapper;
using Pagame.Entities;
using System.Data;
using Pagame.Repository.Interfaces;
using System.Collections.Generic;

namespace Pagame.Repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public bool AddUser(User user)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@userName", user.UserName);
                parameters.Add("@email", user.Email);
                parameters.Add("@phoneNumber", user.PhoneNumber);
                parameters.Add("@roleId", user.RoleId);
                parameters.Add("@salt", user.Salt);
                parameters.Add("@pword", user.Pword);
                SqlMapper.Execute(con, "AddUser", param: parameters, commandType: CommandType.StoredProcedure);

                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public bool DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public IList<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int userId)
        {
            throw new NotImplementedException();
        }

        public User GetUserByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
