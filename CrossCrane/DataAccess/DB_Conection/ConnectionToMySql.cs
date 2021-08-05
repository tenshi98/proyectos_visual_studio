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
            connectionString_1 = "Server=localhost; Database=Database; User=root; port=3306; password=;";
            //example1.cl
            connectionString_2 = "Server=example1.cl; Database=Database; User=root; port=3306; password=;";
            //example2.cl
            connectionString_3 = "Server=example2.cl; Database=Database; User=root; port=3306; password=;";
        }
        protected MySqlConnection GetConnection(string server)
        {
            //selecciono el servidor
            switch (server)
            {
                case "localhost":
                    connectionString = connectionString_1;
                    break;
                case "example1.cl":
                    connectionString = connectionString_2;
                    break;
                case "example2.cl":
                    connectionString = connectionString_3;
                    break;
            }

            return new MySqlConnection(connectionString);

        }
    }
}
