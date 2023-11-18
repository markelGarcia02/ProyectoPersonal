using ProyectoPersonal.Modelo.interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Data
{
	class Inserts : IMetodosInserts
	{

		public string ruta = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProyectoPersonal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		public SqlConnection conexion { get; }

		public Inserts()
		{
			conexion = new SqlConnection(ruta);
		}

		public void InsertarObjeto(int idUser)
		{
			Console.WriteLine("Inserta un precio, por favor:");
			double precio = int.Parse(Console.ReadLine());
			Console.WriteLine("Inserta un titulo, por favor:");
			string titulo = Console.ReadLine();
			Console.WriteLine("Inserta una descripcion, por favor:");
			string descripcion = Console.ReadLine();
			Console.WriteLine("Inserta una foto, por favor:");
			string foto = Console.ReadLine();
			int IdUser = idUser;

			string consulta = "INSERT INTO Objeto(Precio, Titulo, Descripcion, Foto, IdUser) VALUES (" + precio + ",'" + titulo + "','" + descripcion + "','" + foto + "'," + IdUser + ")";
			Console.WriteLine(consulta);
			{

				SqlCommand comando = new SqlCommand(consulta, conexion);

				try
				{

					conexion.Open();

					SqlDataReader miTabla = comando.ExecuteReader();
					Console.WriteLine("Insertado correctamente");
					conexion.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error al insertar!!" + ex.Message);
				}
			}
			Console.ReadKey();
			Console.Clear();
		}

		public void InsertarObjetoCarrito(int idUser)
		{
			Console.WriteLine("Inserte el id del objeto que desea añadir al carrito:");
			int idObjeto = Convert.ToInt32(Console.ReadLine());

			string consulta = "INSERT INTO Carrito (IdUser, IdObjeto) VALUES (" + idUser + "," + idObjeto + ")";
			Console.WriteLine(consulta);
			{

				SqlCommand comando = new SqlCommand(consulta, conexion);

				try
				{

					conexion.Open();

					SqlDataReader miTabla = comando.ExecuteReader();
					Console.WriteLine("Insertado correctamente");
					conexion.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error al insertar!!" + ex.Message);
				}
			}
			Console.ReadKey();
			Console.Clear();
		}

		public string InsertarUsuario()
		{
			string user = "";
			Console.WriteLine("Inserta un email, por favor:");
			string email = Console.ReadLine();
			Console.WriteLine("Inserta un nombre, por favor:");
			string userName = Console.ReadLine();
			Console.WriteLine("Inserta un apellido, por favor:");
			string lastName = Console.ReadLine();
			Console.WriteLine("Inserta una contrasenia, por favor:");
			string contrasenia = Console.ReadLine();
			Console.WriteLine("Inserta un saldo, por favor:");
			int saldo = int.Parse(Console.ReadLine());

			string consulta = "INSERT INTO Usuario(Email, UserName, LastName, Password, Saldo) VALUES ('" + email + "','" + userName + "','" + lastName + "','" + contrasenia + "'," + saldo + ")";
			Console.WriteLine(consulta);
			{

				SqlCommand comando = new SqlCommand(consulta, conexion);

				try
				{
					conexion.Open();

					SqlDataReader miTabla = comando.ExecuteReader();
					Console.WriteLine("Insertado correctamente");
					user = userName;
					conexion.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error al insertar!!" + ex.Message);
				}
			}
			Console.Clear();
			return user;
		}

	}
}
