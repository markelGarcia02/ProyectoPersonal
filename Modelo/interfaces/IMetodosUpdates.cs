using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Modelo.interfaces
{
	public interface IMetodosUpdates
	{
		public void ActualizarSaldoVendedor(int idUser, double precio, double saldoDisponible);
		public void ActualizarSaldoComprador(int idUser, double precio, double saldoDisponible);
	}
}
