using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Common;
using Common.Cache;
using Common.Entities;
using System.Collections;
using DataAccess.DB_Conection;

namespace DataAccess.Data
{
    public class Load_SelectData : ConnectionToMySql
    {
        /*********************************************************************/
        //Sistemas
        public List<Load_SelectEntities> SelectList(string Query, string From, string Join, string Where, string Order, string Server)
        {

            //Declaracion de objeto
            List<Load_SelectEntities> listing = new List<Load_SelectEntities>();

            using (var connection = GetConnection(Server))
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {

                    //consulto la base de datos
                    command.Connection = connection;
                    command.CommandText = "SELECT " + Query + " FROM " + From + " " + Join + " WHERE " + Where + " ORDER BY " + Order;
                    System.Diagnostics.Debug.WriteLine(command.CommandText);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader readRows = command.ExecuteReader();
                    if (readRows.HasRows)
                    {
                        //Pongo el primer dato
                        listing.Add(new Load_SelectEntities
                        {
                            id = 0,
                            Nombre = "Seleccione una Opcion"

                        });
                        //Obtenemos los datos de la columna y asignamos a los campos de la Cache de Usuario
                        while (readRows.Read())
                        {
                            listing.Add(new Load_SelectEntities
                            {
                                id = readRows.GetInt32(0),
                                Nombre = readRows.GetString(1)

                            });


                        }

                    }
                    //devolver objeto
                    return listing;

                }
            }
        }
    }
}
