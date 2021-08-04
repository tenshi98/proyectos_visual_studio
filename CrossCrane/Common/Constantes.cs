using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Constantes
    {

        /************************************************/
        public string SoftData(int type)
        {
            string data = "";
            switch (type)
            {
                //Nombre del software
                case 1:
                    data = "Intranet";
                    break;
                //Slogan del software
                case 2:
                    data = "Software de gestion";
                    break;
                //Nombre de la empresa
                case 3:
                    data = "Crosstech";
                    break;
                //web de la empresa
                case 4:
                    data = "notificaciones@crosstech.cl";
                    break;
                //Version de la app
                case 5:
                    data = "0.0.3";
                    break;


            }

            return data;
        }

        /************************************************/
        public string BaseWeb(string server)
        {
            string data = "";
            //selecciono el servidor
            switch (server)
            {
                case "localhost":
                    data = "http://localhost/power_engine/sistema_intranet_main/";
                    break;
                case "agropraxis.cl":
                    data = "https://agropraxis.crosstech.cl/";
                    break;
                case "crosstech.cl":
                    data = "https://clientes.crosstech.cl/";
                    break;
            }

            return data;
        }





    }
}
