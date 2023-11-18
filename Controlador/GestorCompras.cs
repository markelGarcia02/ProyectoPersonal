using ProyectoPersonal.Data;
using ProyectoPersonal.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controlador
{
    public class GestorCompras
    {
		static Conexion cnn = new Conexion();
		static Updates up = new Updates();

        public void SumarDineroVendedor(int idUser, double precio)
        {
            double saldoDisponible = cnn.ConsultarSaldo(idUser);
			up.ActualizarSaldoVendedor(idUser, precio, saldoDisponible);
		}

		public void RestarDineroComprador(int idUser, double precio)
		{
			double saldoDisponible = cnn.ConsultarSaldo(idUser);
			up.ActualizarSaldoComprador(idUser, precio, saldoDisponible);
		}
	}
}
