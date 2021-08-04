using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
	public static class UserCache
    {
		//ID
		public static int idEstado { get; set; }
		public static int idUsuario { get; set; }
		public static int idTipoUsuario { get; set; }
		public static int idSistema { get; set; }
		public static int COunt { get; set; }
		//Texto
		public static string password { get; set; }
		public static string usuario { get; set; }
		public static string Nombre { get; set; }
		public static string Direccion_img { get; set; }
		public static string Usuario_Tipo { get; set; }
		public static string Region { get; set; }
		public static string Pronostico { get; set; }
		public static string Comuna { get; set; }
		public static string Config_imgLogo { get; set; }
		public static string Config_IDGoogle { get; set; }
		public static string RazonSocial { get; set; }
		public static string Server { get; set; }
		public static string BaseWeb { get; set; }
	}
}
