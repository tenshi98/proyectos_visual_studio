using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public class ServidorList
    {
        public static List<ServidorObject> LoadServidores()
        {
            List<ServidorObject> data = new List<ServidorObject>();
            data.Add(new ServidorObject { NombreServidor = "Seleccione un Servidor" });
            data.Add(new ServidorObject { NombreServidor = "localhost" });
            data.Add(new ServidorObject { NombreServidor = "agropraxis.cl" });
            data.Add(new ServidorObject { NombreServidor = "crosstech.cl" });

            return data;
        }
    }
}
