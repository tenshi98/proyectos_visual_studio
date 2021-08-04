using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Common.Cache;
using Common;
using System.Collections;
using DataAccess.DB_Conection;

namespace DataAccess.Cache
{

    public class UserData : ConnectionToMySql
    {
        /*********************************************************************/
        //Login
        public bool Login(string user, string pass, string server)
        {
            using (var connection = GetConnection(server))
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {

                    //Codifico la contraseña
                    CryptoLib cript = new CryptoLib();
                    var validPassword = cript.MD5Hash(pass);
                    //llamo a las constantes
                    Constantes cons = new Constantes();

                    //consulto la base de datos
                    command.Connection = connection;
                    command.CommandText = "SELECT usuarios_listado.idUsuario as id," +
                        "usuarios_listado.idEstado," +
                        "usuarios_listado.idUsuario," +
                        "usuarios_listado.idTipoUsuario," +
                        "usuarios_listado.password," +
                        "usuarios_listado.usuario," +
                        "usuarios_listado.Nombre," +
                        "usuarios_listado.Direccion_img," +
                        "usuarios_tipos.Nombre AS Usuario_Tipo," +
                        "core_ubicacion_ciudad.Nombre AS nombre_region," +
                        "core_ubicacion_ciudad.Wheater AS nombre_pronostico," +
                        "core_ubicacion_comunas.Nombre AS nombre_comuna," +
                        "(SELECT count(idPermisoSistema) FROM usuarios_sistemas WHERE idUsuario=id) AS COunt " +
                        "FROM usuarios_listado " +
                        "LEFT JOIN `usuarios_tipos` ON usuarios_tipos.idTipoUsuario = usuarios_listado.idTipoUsuario " +
                        "LEFT JOIN `core_ubicacion_ciudad` ON core_ubicacion_ciudad.idCiudad = usuarios_listado.idCiudad " +
                        "LEFT JOIN `core_ubicacion_comunas` ON core_ubicacion_comunas.idComuna = usuarios_listado.idComuna " +
                        "WHERE usuarios_listado.usuario='" + user + "' AND  usuarios_listado.password ='" + validPassword + "'";

                    //Debug.WriteLine(command.CommandText);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        //Obtenemos los datos de la columna y asignamos a los campos de la Cache de Usuario
                        while (reader.Read())
                        {
                            //ID
                            UserCache.idEstado = reader.GetInt32(1);
                            UserCache.idUsuario = reader.GetInt32(2);
                            UserCache.idTipoUsuario = reader.GetInt32(3);
                            UserCache.COunt = reader.GetInt32(12);
                            //Texto
                            UserCache.password = reader.GetString(4);
                            UserCache.usuario = reader.GetString(5);
                            UserCache.Nombre = reader.GetString(6);
                            
                            if (reader.IsDBNull(7)) { UserCache.Direccion_img = ""; } else { UserCache.Direccion_img = reader.GetString(7); }
                            if (reader.IsDBNull(8)) { UserCache.Usuario_Tipo = ""; } else { UserCache.Usuario_Tipo = reader.GetString(8); }
                            if (reader.IsDBNull(9)) { UserCache.Region = ""; } else { UserCache.Region = reader.GetString(9); }
                            if (reader.IsDBNull(10)) { UserCache.Pronostico = ""; } else { UserCache.Pronostico = reader.GetString(10); }
                            if (reader.IsDBNull(11)) { UserCache.Comuna = ""; } else { UserCache.Comuna = reader.GetString(11); }

                            
                            //Guardo el servidor con el que se esta conectando
                            UserCache.Server = server;
                            //Guardo la base de la direccion web del servidor
                            UserCache.BaseWeb = cons.BaseWeb(server);
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

        /*********************************************************************/
        //Login Select
        public bool LoginSelect(int idSistema, string Config_imgLogo, string Config_IDGoogle, string RazonSocial)
        {
            //ID
            UserCache.idSistema        = idSistema;
            UserCache.Config_imgLogo   = Config_imgLogo;
            UserCache.Config_IDGoogle  = Config_IDGoogle;
            UserCache.RazonSocial      = RazonSocial;

            return true;
        }


    }
}
