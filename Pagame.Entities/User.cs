using System;
namespace Pagame.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int RoleId { get; set; }
        public string Salt { get; set; }
        public string Pword { get; set; }


    }
}
