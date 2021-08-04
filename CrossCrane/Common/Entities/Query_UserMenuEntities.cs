using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Query_UserMenuEntities
	{
		/******************************/
		//ID
		private int _idAdmpm { get; set; }
		private int _TransaccionCat { get; set; }
		private int _level { get; set; }
		//Texto
		private string _CategoriaNombre { get; set; }
		private string _CategoriaIcono { get; set; }
		private string _CategoriaIconoColor { get; set; }
		private string _TransaccionURLBase { get; set; }
		private string _TransaccionURL { get; set; }
		private string _TransaccionNombre { get; set; }
		


		/******************************/
		//objeto
		public int idAdmpm { get => _idAdmpm; set => _idAdmpm = value; }
		public int TransaccionCat { get => _TransaccionCat; set => _TransaccionCat = value; }
		public int level { get => _level; set => _level = value; }
		public string CategoriaNombre { get => _CategoriaNombre; set => _CategoriaNombre = value; }
		public string CategoriaIcono { get => _CategoriaIcono; set => _CategoriaIcono = value; }
		public string CategoriaIconoColor { get => _CategoriaIconoColor; set => _CategoriaIconoColor = value; }
		public string TransaccionURLBase { get => _TransaccionURLBase; set => _TransaccionURLBase = value; }
		public string TransaccionURL { get => _TransaccionURL; set => _TransaccionURL = value; }
		public string TransaccionNombre { get => _TransaccionNombre; set => _TransaccionNombre = value; }
		
	}
}
