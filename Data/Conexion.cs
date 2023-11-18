using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using ProyectoPersonal.Modelo;
using ProyectoPersonal.Modelo.interfaces;
using System.Data.SqlClient;
using ProyectoPersonal.Controlador.Menus;
using System.Reflection;
using System.Collections;

namespace ProyectoPersonal.Data
{
    public class Conexion : IMetodosConexion
    {

		public string ruta = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProyectoPersonal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		public SqlConnection conexion { get; }
		
		public Conexion()
		{
			conexion = new SqlConnection(ruta);
		}

		public void LeerObjetosDeUsuario( int idUser ) 
		{
			string consulta = "SELECT * FROM Objeto WHERE IdUser=";
			{
				consulta = consulta + idUser;
				SqlCommand comando = new SqlCommand(consulta, conexion);

				try
				{
					conexion.Open();

					using (SqlDataReader miTabla = comando.ExecuteReader())
					{
						Console.WriteLine("------------Mis objetos----------------");
						while (miTabla.Read())
						{
							Console.WriteLine("{0} {1} {2} {3} {4} {5}", miTabla["IdObjeto"].ToString(), miTabla["Precio"].ToString(), miTabla["Titulo"].ToString(), miTabla["Descripcion"].ToString(), miTabla["Foto"].ToString(), miTabla["IdUser"].ToString());
						}
					}
					conexion.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error al leer!!" + ex.Message);
				}
			}
			Console.ReadKey();
			Console.Clear();
		}

		public void ExplorarObjetos()
		{
			
			string consulta = "SELECT * FROM Objeto";
			{
				SqlCommand comando = new SqlCommand(consulta, conexion);

				try
				{
					conexion.Open();

					using (SqlDataReader miTabla = comando.ExecuteReader())
					{
						Console.WriteLine("------------Objetos en venta----------------");
						while (miTabla.Read())
						{
							Console.WriteLine("{0} {1} {2} {3} {4} {5}", miTabla["IdObjeto"].ToString(), miTabla["Precio"].ToString(), miTabla["Titulo"].ToString(), miTabla["Descripcion"].ToString(), miTabla["Foto"].ToString(), miTabla["IdUser"].ToString());
							
						}
					}
					conexion.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error al leer!!" + ex.Message);
				}
			}
			Console.ReadKey();
			Console.Clear();
		}

		public double ConsultarSaldo(int idUser)
		{
			double saldoDisponible = 0;
			string consulta = "SELECT Saldo FROM Usuario WHERE IdUser=";
			{
				consulta = consulta + idUser;
				SqlCommand comando = new SqlCommand(consulta, conexion);

				try
				{
					conexion.Open();

					using (SqlDataReader miTabla = comando.ExecuteReader())
					{
						Console.WriteLine("-------Saldo disponible-------");
						while (miTabla.Read())
						{
							Console.WriteLine("{0}", miTabla["Saldo"].ToString());
							saldoDisponible = Convert.ToDouble(miTabla["Saldo"].ToString());
						}
					}
					conexion.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error al leer!!" + ex.Message);
				}
			}
			Console.ReadKey();
			Console.Clear();
			return saldoDisponible;
		}

		public void VerCarrito(int idUser)
		{
			string consulta = "SELECT * FROM Carrito WHERE IdUser=";
			{
				consulta = consulta + idUser;
				SqlCommand comando = new SqlCommand(consulta, conexion);

				try
				{
					conexion.Open();

					using (SqlDataReader miTabla = comando.ExecuteReader())
					{
						Console.WriteLine("-------Carrito-------");
						while (miTabla.Read())
						{
							Console.WriteLine("{0} {1}", miTabla["IdUser"].ToString(), miTabla["IdObjeto"].ToString());
						}
					}
					conexion.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error al leer!!" + ex.Message);
				}
			}
			Console.ReadKey();
			Console.Clear();
		}

		public List<int> ListaObjetosCarrito(int idUser)
		{
			List<int> ListaIdObjetos = new List<int>();
			string consulta = "SELECT * FROM Carrito WHERE IdUser=";
			{
				consulta = consulta + idUser;
				SqlCommand comando = new SqlCommand(consulta, conexion);

				try
				{
					conexion.Open();

					using (SqlDataReader miTabla = comando.ExecuteReader())
					{
						while (miTabla.Read())
						{
							ListaIdObjetos.Add(Convert.ToInt32(miTabla["IdObjeto"].ToString()));
						}
					}
					conexion.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error al leer!!" + ex.Message);
				}
			}
			Console.ReadKey();
			Console.Clear();
			return ListaIdObjetos;
		}

		public void PrecioCarrito(int idUser)
		{
			string consulta = "SELECT SUM(Precio) AS PrecioTotal FROM Objeto as o INNER JOIN Carrito as c ON o.IdObjeto = c.IdObjeto WHERE c.IdUser=";
			{
				consulta = consulta + idUser;
				SqlCommand comando = new SqlCommand(consulta, conexion);

				try
				{
					conexion.Open();

					using (SqlDataReader miTabla = comando.ExecuteReader())
					{
						Console.WriteLine("-------Precio Carrito-------");
						while (miTabla.Read())
						{
							Console.WriteLine("{0}", miTabla["PrecioTotal"].ToString());
						}
					}
					conexion.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error al leer!!" + ex.Message);
				}
			}
			Console.ReadKey();
			Console.Clear();
		}

		public List<int> IdVendedor(int idUser)
		{
			List<int> IdVendedores = new List<int>();

			string consulta = "SELECT o.IdUser FROM Objeto as o INNER JOIN Carrito as c ON o.IdObjeto = c.IdObjeto WHERE c.IdUser=";
			consulta = consulta + idUser;
			{
				SqlCommand comando = new SqlCommand(consulta, conexion);

				try
				{
					conexion.Open();

					using (SqlDataReader miTabla = comando.ExecuteReader())
					{
						while (miTabla.Read())
						{
							int Id = Convert.ToInt32(miTabla["IdUser"].ToString());
							IdVendedores.Add(Id);
						}
					}
					conexion.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error al leer!!" + ex.Message);
					return null;
				}
			}
			Console.Clear();
			return IdVendedores;
		}

		public List<double> PrecioObjetoCarrito(int idUser)
		{
			List<double> PrecioObjetoCarrito = new List<double>();

			string consulta = "SELECT o.Precio FROM Objeto as o INNER JOIN Carrito as c ON o.IdObjeto = c.IdObjeto WHERE c.IdUser=";
			consulta = consulta + idUser;
			{
				SqlCommand comando = new SqlCommand(consulta, conexion);

				try
				{
					conexion.Open();

					using (SqlDataReader miTabla = comando.ExecuteReader())
					{
						while (miTabla.Read())
						{
							int Id = Convert.ToInt32(miTabla["Precio"].ToString());
							PrecioObjetoCarrito.Add(Id);
						}
					}
					conexion.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error al leer!!" + ex.Message);
					return null;
				}
			}
			Console.Clear();
			return PrecioObjetoCarrito;
		}

		

	}
}
