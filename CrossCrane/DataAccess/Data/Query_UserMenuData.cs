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

    public class Query_UserMenuData : ConnectionToMySql
    {
        /*********************************************************************/
        //Sistemas
        public List<Query_UserMenuEntities> UserMenuList(int idUsuario, int idTipoUsuario, string server)
        {

            //Declaracion de objeto
            List<Query_UserMenuEntities> listing = new List<Query_UserMenuEntities>();

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
                        command.CommandText = "SELECT core_permisos_listado.idAdmpm AS idAdmpm," +
                            "core_permisos_categorias.Nombre AS CategoriaNombre," +
                            "core_font_awesome.Codigo AS CategoriaIcono," +
                            "core_permisos_categorias.IconColor AS CategoriaIconoColor," +
                            "core_permisos_listado.Direccionbase AS TransaccionURLBase," +
                            "core_permisos_listado.Direccionweb AS TransaccionURL," +
                            "core_permisos_listado.Nombre AS TransaccionNombre, " +
                            "core_permisos_listado.id_pmcat AS TransaccionCat " +
                            "FROM core_permisos_listado " +
                            "INNER JOIN core_permisos_categorias  ON core_permisos_categorias.id_pmcat  = core_permisos_listado.id_pmcat " +
                            "LEFT JOIN `core_font_awesome`        ON core_font_awesome.idFont           = core_permisos_categorias.idFont " +
                            "ORDER BY CategoriaNombre ASC, TransaccionNombre ASC";
                        
                        //Debug.WriteLine(command.CommandText);
                        command.CommandType = CommandType.Text;
                        MySqlDataReader readRows = command.ExecuteReader();


                        if (readRows.HasRows)
                        {
                            //Obtenemos los datos de la columna y asignamos a los campos de la Cache de Usuario
                            while (readRows.Read())
                            {
                                listing.Add(new Query_UserMenuEntities
                                {
                                    idAdmpm = readRows.GetInt32(0),
                                    CategoriaNombre = readRows.GetString(1),
                                    CategoriaIcono = readRows.GetString(2),
                                    CategoriaIconoColor = readRows.GetString(3),
                                    TransaccionURLBase = readRows.GetString(4),
                                    TransaccionURL = readRows.GetString(5),
                                    TransaccionNombre = readRows.GetString(6),
                                    TransaccionCat = readRows.GetInt32(7),
                                    level = 4

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
                        command.CommandText = "SELECT core_permisos_listado.idAdmpm AS idAdmpm," +
                            "core_permisos_categorias.Nombre AS CategoriaNombre," +
                            "core_font_awesome.Codigo AS CategoriaIcono," +
                            "core_permisos_categorias.IconColor AS CategoriaIconoColor," +
                            "core_permisos_listado.Direccionbase AS TransaccionURLBase," +
                            "core_permisos_listado.Direccionweb AS TransaccionURL," +
                            "core_permisos_listado.Nombre AS TransaccionNombre, " +
                            "core_permisos_listado.id_pmcat AS TransaccionCat, " +
                            "usuarios_permisos.level AS TransaccionLimitLevel " +
                            "FROM usuarios_permisos " +
                            "INNER JOIN core_permisos_listado      ON core_permisos_listado.idAdmpm        = usuarios_permisos.idAdmpm " +
                            "INNER JOIN core_permisos_categorias   ON core_permisos_categorias.id_pmcat    = core_permisos_listado.id_pmcat " +
                            "LEFT JOIN `core_font_awesome`         ON core_font_awesome.idFont             = core_permisos_categorias.idFont " +
                            "WHERE usuarios_permisos.idUsuario = " + idUsuario + " " +
                            "ORDER BY CategoriaNombre ASC, TransaccionNombre ASC";

                        //Debug.WriteLine(command.CommandText);
                        command.CommandType = CommandType.Text;
                        MySqlDataReader readRows = command.ExecuteReader();

                        if (readRows.HasRows)
                        {
                            //Obtenemos los datos de la columna y asignamos a los campos de la Cache de Usuario
                            while (readRows.Read())
                            {
                                listing.Add(new Query_UserMenuEntities
                                {
                                    idAdmpm = readRows.GetInt32(0),
                                    CategoriaNombre = readRows.GetString(1),
                                    CategoriaIcono = readRows.GetString(2),
                                    CategoriaIconoColor = readRows.GetString(3),
                                    TransaccionURLBase = readRows.GetString(4),
                                    TransaccionURL = readRows.GetString(5),
                                    TransaccionNombre = readRows.GetString(6),
                                    TransaccionCat = readRows.GetInt32(7),
                                    level = readRows.GetInt32(8)

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
}
