using ProyectoPersonal.Modelo.interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Data
{
	class Updates : IMetodosUpdates
	{

		public string ruta = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProyectoPersonal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		public SqlConnection conexion { get; }

		public Updates()
		{
			conexion = new SqlConnection(ruta);
		}

		public void ActualizarSaldoVendedor(int idUser, double precio, double saldoDisponible)
		{
			double saldoActualizado = saldoDisponible + precio;
			string consulta = "UPDATE Usuario SET Saldo = " + saldoActualizado + " WHERE IdUser =" + idUser;

			{

				SqlCommand comando = new SqlCommand(consulta, conexion);

				try
				{

					conexion.Open();

					SqlDataReader miTabla = comando.ExecuteReader();

					Console.WriteLine("Saldo del vendedor actualizado correctamente");
					conexion.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error al actualizar!!" + ex.Message);
				}
			}
			Console.ReadKey();
			Console.Clear();
		}

		public void ActualizarSaldoComprador(int idUser, double precio, double saldoDisponible)
		{
			double saldoActualizado = saldoDisponible - precio;
			string consulta = "UPDATE Usuario SET Saldo = " + saldoActualizado + " WHERE IdUser =" + idUser;

			{

				SqlCommand comando = new SqlCommand(consulta, conexion);

				try
				{

					conexion.Open();

					SqlDataReader miTabla = comando.ExecuteReader();

					Console.WriteLine("Saldo del comprador actualizado correctamente");
					conexion.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error al actualizar!!" + ex.Message);
				}
			}
			Console.ReadKey();
			Console.Clear();
		}
	}
}
