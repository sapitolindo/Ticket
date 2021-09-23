using System;
using System.Collections.Generic;
using System.Text;

namespace BasicApp.Services
{
    public interface ILoginService
    {
        bool TrueLogin(String user, String password);
    }
}
