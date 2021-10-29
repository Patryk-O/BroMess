using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BroMess.Server.Users
{
    public interface IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public byte[] Avatar { get; set; }

        public bool CreateUser();
        public bool Login();
        public IUser FindUser();
    }
}
