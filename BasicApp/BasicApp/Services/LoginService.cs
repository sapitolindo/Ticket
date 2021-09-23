using System;
using System.Collections.Generic;
using System.Text;
using BasicApp.Functions;
using BasicApp.Model;
using BasicApp.Services;

namespace BasicApp.Services
{
    class LoginService : ILoginService
    {
        List<User> users;
        AddUser userList = new AddUser();
        public LoginService()
        {
             
        }

        public bool TrueLogin(string user, string password)
        {
            users = userList.GetUsers();
            foreach (var us in users)
            {
                if (user == us.user_name & user == us.password)
                {
                    return true;
                }
            }return false;
        }
    }
}
