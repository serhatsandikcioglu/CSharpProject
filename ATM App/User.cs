using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }

        public void CreateUser(string id, string name, string surname, string password, int balance)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Password = password;
            this.Balance = balance;
        }
        public static List<User> Users = new List<User>();
        static User()
        {
            Users.Add(new User { Id = "1", Name = "UserName1", Surname = "SurName1", Password = "123456", Balance = 500 });
            Users.Add(new User { Id = "2", Name = "UserName2", Surname = "SurName2", Password = "123456", Balance = 5000 });
            Users.Add(new User { Id = "3", Name = "UserName3", Surname = "SurName3", Password = "123456", Balance = 0 });
        }

    }
}
