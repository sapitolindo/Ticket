using BasicApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicApp.Functions
{
    class AddUser
    {
        public readonly List<User> users;
        
        public AddUser()
        {
            users = new List<User>()
            {
                new User {id = Int32.Parse(Guid.NewGuid().ToString()), user_name = "usuario", password = "1234"},
                new User {id = Int32.Parse(Guid.NewGuid().ToString()), user_name = "abc" , password = "0987"}
            };
        }

        public List<User> GetUsers() { return users; }
    }
}
