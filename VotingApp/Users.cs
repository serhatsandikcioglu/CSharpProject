using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp
{
    public class Users
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public void CreateUser(string userName,string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
