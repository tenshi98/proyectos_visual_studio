using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Data;
using Common.Entities;

namespace Domain.Business
{
    public class Query_CoreSistemasBusiness
    {
        Query_CoreSistemasData data = new Query_CoreSistemasData();

        //Listo los datos
        public List<Query_CoreSistemasEntities> ListaSistema(int idUsuario, int idTipoUsuario, string server)
        {
            return data.CoreSistemasList(idUsuario, idTipoUsuario, server);
        }

        //Muestro un dato
        public bool ListaUnSistema(int idUsuario, string server)
        {
            return data.ListaUnSistema(idUsuario, server);
        }
    }
}
