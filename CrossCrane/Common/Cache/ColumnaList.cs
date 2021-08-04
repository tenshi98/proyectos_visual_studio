using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public class ColumnaList
    {
        public static List<ColumnaObject> LoadData(String Data)
        {
            List<ColumnaObject> data = new List<ColumnaObject>();
            //Separo los datos
            string[] subs = Data.Split(',');
            //Pongo Contador
            int Count = 0;
            //Agrego encabezado
            data.Add(new ColumnaObject { ID = Count, Nombre = "Seleccione una Opcion" });
            //Recorro datos
            foreach (var sub in subs)
            {
                Count++;
                data.Add(new ColumnaObject { ID = Count, Nombre = sub });
            }

            return data;
        }
    }
}
