using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Modelo.interfaces
{
	public interface IMetodosDeletes
	{
		public void BorrarCarrito(int idUser);
		public void BorrarObjeto(int idObjeto);
	}
}
