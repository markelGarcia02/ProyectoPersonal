using ProyectoPersonal.Modelo.interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Data
{
	class Sesion : IMetodosSesion
	{
		public string ruta = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProyectoPersonal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		public SqlConnection conexion { get; }

		public Sesion()
		{
			conexion = new SqlConnection(ruta);
		}

		public List<string> LeerUserName()
		{
			List<string> UserNames = new List<string>();
			string consulta = "SELECT UserName FROM Usuario";
			{
				SqlCommand comando = new SqlCommand(consulta, conexion);

				try
				{

					conexion.Open();

					using (SqlDataReader miTabla = comando.ExecuteReader())
					{
						while (miTabla.Read())
						{
							UserNames.Add(miTabla["UserName"].ToString());
						}
					}
					conexion.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error al leer!!" + ex.Message);
				}
			}
			Console.Clear();
			return UserNames;
		}

		public List<string> LeerPassword()
		{
			List<string> Passwords = new List<string>();
			string consulta = "SELECT Password FROM Usuario";
			{
				SqlCommand comando = new SqlCommand(consulta, conexion);

				try
				{

					conexion.Open();

					using (SqlDataReader miTabla = comando.ExecuteReader())
					{
						while (miTabla.Read())
						{
							Passwords.Add(miTabla["Password"].ToString());
						}
					}
					conexion.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error al leer!!" + ex.Message);
				}
			}
			Console.Clear();
			return Passwords;
		}
		public int SacarIdActivoPass(string pass)
		{
			int idActivo = 0;
			string consulta = "SELECT IdUser FROM Usuario WHERE Password=";
			consulta = consulta + "'" + pass + "'";
			{
				SqlCommand comando = new SqlCommand(consulta, conexion);

				try
				{

					conexion.Open();

					using (SqlDataReader miTabla = comando.ExecuteReader())
					{
						while (miTabla.Read())
						{
							idActivo = Convert.ToInt32(miTabla["IdUser"].ToString());
						}
					}
					conexion.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error al leer!!" + ex.Message);
				}
			}
			Console.Clear();
			return idActivo;
		}

		public int SacarIdActivoUser(string user)
		{
			int idActivo = 0;
			string consulta = "SELECT IdUser FROM Usuario WHERE UserName=";
			consulta = consulta + "'" + user + "'";
			{
				SqlCommand comando = new SqlCommand(consulta, conexion);

				try
				{

					conexion.Open();

					using (SqlDataReader miTabla = comando.ExecuteReader())
					{
						while (miTabla.Read())
						{
							idActivo = Convert.ToInt32(miTabla["IdUser"].ToString());
						}
					}
					conexion.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error al leer!!" + ex.Message);
				}
			}
			Console.Clear();
			return idActivo;
		}
	}
}
