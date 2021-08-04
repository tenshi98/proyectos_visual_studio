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

    public class Query_CoreSistemasData : ConnectionToMySql
    {
        /*********************************************************************/
        //Sistemas
        public List<Query_CoreSistemasEntities> CoreSistemasList(int idUsuario, int idTipoUsuario, string server)
        {

            //Declaracion de objeto
            List<Query_CoreSistemasEntities> listing = new List<Query_CoreSistemasEntities>();

            using (var connection = GetConnection(server))
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {

                    /**********************************************/
                    //si es superusuario
                    if (idTipoUsuario == 1)
                    {
                        //consulto la base de datos
                        command.Connection = connection;
                        command.CommandText = "SELECT idSistema, Config_imgLogo, Config_IDGoogle, Nombre AS RazonSocial " +
                            "FROM core_sistemas " +
                            "WHERE core_sistemas.idEstado=1 " +
                            "ORDER BY Nombre ASC";

                        //Debug.WriteLine(command.CommandText);
                        command.CommandType = CommandType.Text;
                        MySqlDataReader readRows = command.ExecuteReader();


                        if (readRows.HasRows)
                        {
                            //Obtenemos los datos de la columna y asignamos a los campos de la Cache de Usuario
                            while (readRows.Read())
                            {
                                listing.Add(new Query_CoreSistemasEntities
                                {
                                    idSistema = readRows.GetInt32(0),
                                    Config_imgLogo = readRows.GetString(1),
                                    Config_IDGoogle = readRows.GetString(2),
                                    RazonSocial = readRows.GetString(3)

                                });


                            }

                        }
                        //devolver objeto
                        return listing;
                    }
                    /**********************************************/
                    //si es usuario normal
                    else
                    {
                        //consulto la base de datos
                        command.Connection = connection;
                        command.CommandText = "SELECT core_sistemas.idSistema," +
                            "core_sistemas.Config_imgLogo," +
                            "core_sistemas.Config_IDGoogle," +
                            "core_sistemas.Nombre AS RazonSocial " +
                            "FROM usuarios_sistemas " +
                            "LEFT JOIN `core_sistemas`  ON core_sistemas.idSistema  = usuarios_sistemas.idSistema " +
                            "WHERE usuarios_sistemas.idUsuario = " + idUsuario + " AND core_sistemas.idEstado=1 " +
                            "ORDER BY Nombre ASC";

                        //Debug.WriteLine(command.CommandText);
                        command.CommandType = CommandType.Text;
                        MySqlDataReader readRows = command.ExecuteReader();

                        if (readRows.HasRows)
                        {
                            //Obtenemos los datos de la columna y asignamos a los campos de la Cache de Usuario
                            while (readRows.Read())
                            {
                                listing.Add(new Query_CoreSistemasEntities
                                {
                                    idSistema = readRows.GetInt32(0),
                                    Config_imgLogo = readRows.GetString(1),
                                    Config_IDGoogle = readRows.GetString(2),
                                    RazonSocial = readRows.GetString(3)

                                });
                            }

                        }
                        //devolver objeto
                        return listing;
                    }

                }
            }


        }

        /*********************************************************************/
        //Login
        public bool ListaUnSistema(int idUsuario, string server)
        {
            using (var connection = GetConnection(server))
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    //consulto la base de datos
                    command.Connection = connection;
                    command.CommandText = "SELECT core_sistemas.idSistema," +
                            "core_sistemas.Config_imgLogo," +
                            "core_sistemas.Config_IDGoogle," +
                            "core_sistemas.Nombre AS RazonSocial " +
                            "FROM usuarios_sistemas " +
                            "LEFT JOIN `core_sistemas`  ON core_sistemas.idSistema  = usuarios_sistemas.idSistema " +
                            "WHERE usuarios_sistemas.idUsuario = " + idUsuario + " AND core_sistemas.idEstado=1 " +
                            "ORDER BY Nombre ASC";

                    //Debug.WriteLine(command.CommandText);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        //Obtenemos los datos de la columna y asignamos a los campos de la Cache de Usuario
                        while (reader.Read())
                        {
                            //ID
                            UserSystem.idSistema = reader.GetInt32(0);
                            //Texto
                            UserSystem.Config_imgLogo = reader.GetString(1);
                            UserSystem.Config_IDGoogle = reader.GetString(2);
                            UserSystem.RazonSocial = reader.GetString(3);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }



    }
}
