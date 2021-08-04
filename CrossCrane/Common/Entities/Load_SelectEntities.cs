using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
	public class Load_SelectEntities
    {
		/******************************/
		//ID
		private int _id { get; set; }
		//Texto
		private string _Nombre { get; set; }
		
		/******************************/
		//objeto
		public int id { get => _id; set => _id = value; }
		public string Nombre { get => _Nombre; set => _Nombre = value; }
	}
}
