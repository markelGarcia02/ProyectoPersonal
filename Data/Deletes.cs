using ProyectoPersonal.Modelo.interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Data
{
	class Deletes : IMetodosDeletes
	{
		public string ruta = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProyectoPersonal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		public SqlConnection conexion { get; }

		public Deletes()
		{
			conexion = new SqlConnection(ruta);
		}

		public void BorrarCarrito(int idUser)
		{
			string consulta = "DELETE FROM Carrito WHERE IdUser=";

			consulta = consulta + idUser;

			{

				SqlCommand comando = new SqlCommand(consulta, conexion);

				try
				{
					conexion.Open();

					SqlDataReader miTabla = comando.ExecuteReader();

					Console.WriteLine("Eliminado!");
					conexion.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error al eliminar!!" + ex.Message);
				}
			}
			Console.ReadKey();
			Console.Clear();
		}


		public void BorrarObjeto(int idObjeto)
		{
			string consulta = "DELETE FROM Objeto WHERE IdObjeto=";

			consulta = consulta + idObjeto;

			{

				SqlCommand comando = new SqlCommand(consulta, conexion);

				try
				{
					conexion.Open();

					SqlDataReader miTabla = comando.ExecuteReader();

					Console.WriteLine("Eliminado!");
					conexion.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error al eliminar!!" + ex.Message);
				}
			}
			Console.ReadKey();
			Console.Clear();
		}

	}
}
