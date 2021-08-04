using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Cache;

namespace Domain.Cache
{
    public class UserModel
    {
        UserData userData = new UserData();
        //Login
        public bool LoginUser(string user, string pass, string server)
        {
            return userData.Login(user, pass, server);
        }
        //Login_select
        public bool LoginSelectSystem(int idSistema, string Config_imgLogo, string Config_IDGoogle, string RazonSocial)
        {
            return userData.LoginSelect(idSistema, Config_imgLogo, Config_IDGoogle, RazonSocial);
        }
        

    }
}
