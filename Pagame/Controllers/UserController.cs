using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pagame.Business.Interfaces;
using Pagame.Entities;

namespace PagameAPI
{
    [Route("api/[controller]/")]
    public class UserController : Controller
    {
        private IUserManager _userManager;
        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        //  GET api/user
        [HttpGet]
        public IEnumerable< User > Get()
        {
            return _userManager.GetAllUsers();
        }

        //  GET api/user/{id}
        [HttpGet("{id:int")]
        public User GetUserById(int id)
        {
            return _userManager.GetUserByUserId(id);
        }

        //  POST api/user
        [HttpPost]
        public void AddUser([FromBody] User user)
        {
            _userManager.AddUser(user);
        }

        //  PUT api/user/{id}
        [HttpPut("{id:int")]
        public void UpdateUser([FromBody] User user)
        {
            _userManager.UpdateUser(user);
        }

        //  DELETE api/user/{id}
        [HttpDelete("{id:int")]
        public void DeleteUser(int id)
        {
            _userManager.DeleteUser(id);
        }
    }
}
