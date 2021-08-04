using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataAccess.DB_Conection
{
    public abstract class ConnectionToMySql
    {
        private readonly string connectionString_1, connectionString_2, connectionString_3;
        private string connectionString;
        public ConnectionToMySql()
        {
            //localhost
            connectionString_1 = "Server=localhost; Database=power_engine_main; User=root; port=3306; password=;";
            //agropraxis.cl
            connectionString_2 = "Server=crosstech.cl; Database=crosstech_pe_agropraxis; User=crosstech_admin; port=3306; password=&-VSda,#rFvT;";
            //crosstech.cl
            connectionString_3 = "Server=crosstech.cl; Database=crosstech_pe_clientes; User=crosstech_admin; port=3306; password=&-VSda,#rFvT;";
        }
        protected MySqlConnection GetConnection(string server)
        {
            //selecciono el servidor
            switch (server)
            {
                case "localhost":
                    connectionString = connectionString_1;
                    break;
                case "agropraxis.cl":
                    connectionString = connectionString_2;
                    break;
                case "crosstech.cl":
                    connectionString = connectionString_3;
                    break;
            }

            return new MySqlConnection(connectionString);

        }
    }
}
