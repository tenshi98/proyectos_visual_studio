using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Query_CoreSistemasEntities
    {
		/******************************/
		//ID
		private int _idSistema { get; set; }
		//Texto
		private string _Config_imgLogo { get; set; }
		private string _Config_IDGoogle { get; set; }
		private string _RazonSocial { get; set; }


		/******************************/
		//objeto
		public int idSistema { get => _idSistema; set => _idSistema = value; }
		public string Config_imgLogo { get => _Config_imgLogo; set => _Config_imgLogo = value; }
		public string Config_IDGoogle { get => _Config_IDGoogle; set => _Config_IDGoogle = value; }
		public string RazonSocial { get => _RazonSocial; set => _RazonSocial = value; }
	}
}
