using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Modelo.interfaces
{
	public interface IMetodosInserts
	{
		public void InsertarObjeto(int idUser);
		public void InsertarObjetoCarrito(int idUser);
		public string InsertarUsuario();
	}
}
