using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Data;
using Common.Entities;

namespace Domain.Business
{
    public class Query_UserMenuBusiness
    {
        Query_UserMenuData data = new Query_UserMenuData();

        //Listo los datos
        public List<Query_UserMenuEntities> ListaMenu(int idUsuario, int idTipoUsuario, string server)
        {
            return data.UserMenuList(idUsuario, idTipoUsuario, server);
        }
    }
}
