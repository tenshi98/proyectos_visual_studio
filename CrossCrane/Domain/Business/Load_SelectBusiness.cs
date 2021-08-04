using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Data;
using Common.Entities;

namespace Domain.Business
{
    public class Load_SelectBusiness
    {
        Load_SelectData data = new Load_SelectData();

        //Listo los datos
        public List<Load_SelectEntities> SelectList(string Query, string From, string Join, string Where, string Order, string Server)
        {
            return data.SelectList(Query, From, Join, Where, Order, Server);
        }
    }
}
