using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using ProyectoPersonal.Modelo;
using ProyectoPersonal.Modelo.interfaces;

namespace ProyectoPersonal.Data
{
    public class Conexion : IMetodosBD
    {
        public string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markgarcia\source\repos\ProyectoPersonal\ProyectoPersonalMarkel.mdb";
        public OleDbConnection conexion { get; }
        public Conexion()
        {
            conexion = new OleDbConnection(ruta);
        }

        public void leerUsuariosBD()
        {
            string consulta = "SELECT * FROM usuario";
            {
                    
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                   
                try
                {
                        
                    conexion.Open();
                     
                    using (OleDbDataReader miTabla = comando.ExecuteReader())
                    {
                        Console.WriteLine("------------Tabla usuario----------------");
                        while (miTabla.Read())
                        {
                            Console.WriteLine("{0} {1} {2} {3} {4}", miTabla["IdUsuario"].ToString(), miTabla["email"].ToString(), miTabla["nombreUsuario"].ToString(), miTabla["contrasenia"].ToString(), miTabla["saldo"].ToString());
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

        public void leerObjetosBD()
        {
            string consulta = "SELECT * FROM objeto";
            {
                
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                   
                try
                {
                     
                    conexion.Open();
                      
                    using (OleDbDataReader miTabla = comando.ExecuteReader())
                    {
                        Console.WriteLine("------------Tabla objeto----------------");
                        while (miTabla.Read())
                        {
                            Console.WriteLine("{0} {1} {2} {3} {4} {5}", miTabla["IdObjeto"].ToString(), miTabla["precio"].ToString(), miTabla["titulo"].ToString(), miTabla["descripcion"].ToString(), miTabla["foto"].ToString(), miTabla["IdUsuario"].ToString());
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

        public void eliminarUsuarioDeDB()
        {
            string consulta = "DELETE FROM usuario WHERE IdUsuario=";
            int id;

            Console.WriteLine("¿Qué id quieres eliminar?");
            id = int.Parse(Console.ReadLine());
            consulta = consulta + id;
            
            {
                
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                 
                try
                {    
                    conexion.Open();   

                    OleDbDataReader miTabla = comando.ExecuteReader();

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

        public void eliminarObjetoDeDB()
        {
            string consulta = "DELETE FROM objeto WHERE IdObjeto=";
            int id;

            Console.WriteLine("¿Qué id quieres eliminar?");
            id = int.Parse(Console.ReadLine());
            consulta = consulta + id;
            
            {
                  
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                 
                try
                {   
                    conexion.Open();    

                    OleDbDataReader miTabla = comando.ExecuteReader();

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
        public void insertarUsuarioEnBD()
        {
            Console.WriteLine("Inserta un email, por favor:");
            string email = Console.ReadLine();
            Console.WriteLine("Inserta un nombre, por favor:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Inserta una contrasenia, por favor:");
            string contrasenia = Console.ReadLine();
            Console.WriteLine("Inserta un saldo, por favor:");
            int saldo = int.Parse(Console.ReadLine());
            
            string consulta = "INSERT INTO usuario(Email, NombreUsuario, Contrasenia, Saldo) VALUES ('" + email + "','" + nombre + "','" + contrasenia + "'," + saldo + ")";
            Console.WriteLine(consulta);
            {
               
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                
                try
                {
                    
                    conexion.Open();
                       
                    OleDbDataReader miTabla = comando.ExecuteReader();
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

        public void insertarObjetoEnBD(int idUser)
        {
            Console.WriteLine("Inserta un titulo, por favor:");
            string titulo = Console.ReadLine();
            Console.WriteLine("Inserta una descripcion, por favor:");
            string descripcion = Console.ReadLine();
            Console.WriteLine("Inserta una foto, por favor:");
            string foto = Console.ReadLine();
            Console.WriteLine("Inserta un precio, por favor:");
            double precio = int.Parse(Console.ReadLine());
            int idUsuario = idUser;
            
            string consulta = "INSERT INTO objeto(Titulo, Descripcion, Foto, Precio, IdUsuario) VALUES ('" + titulo + "','" + descripcion + "','" + foto + "'," + precio + "," + idUsuario + ")";
            Console.WriteLine(consulta);
            {
                
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                   
                try
                {
                       
                    conexion.Open();
                     
                    OleDbDataReader miTabla = comando.ExecuteReader();
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

        public void aniadirObjetoCarrito(int idUser, Objeto obj, double totalPrecio)
        {
            int idUsuario = idUser;
            int idObjeto = obj.IdObjeto;
            
            string consulta = "INSERT INTO carrito(IdUsuario, IdObjeto, TotalPrecio) VALUES (" + idUsuario + "," + idObjeto + "," + totalPrecio + ")";
            Console.WriteLine(consulta);
            {
                  
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                   
                try
                {
                        
                    conexion.Open();
                        
                    OleDbDataReader miTabla = comando.ExecuteReader();
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

        public void actualizarUsuarioEnBD()
        {
            int opc;
            int id;
            string email = "";
            string nombre = "";
            string contrasenia = "";
            double saldo = 0;
            string consultaBase = "UPDATE usuario SET  ";
            string consultaEmail = "";
            string consultaNombre = "";
            string consultaContrasenia = "";
            string consultaSaldo = "";
            Console.WriteLine("¿Qué id quieres actualizar?");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Qué quieres actualizar?\n 1)Email\n 2)NombreUsuario\n 3)Contrasenia\n 4)Saldo\n 0)Salir");
            opc = int.Parse(Console.ReadLine());
            do
            {
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Inserta un email, por favor:");
                        email = Console.ReadLine();
                        consultaEmail = consultaBase + " Email = '" + email + "' WHERE IdUsuario = " + id;
                        break;
                    case 2:
                        Console.WriteLine("Inserta el nombre, por favor:");
                        nombre = Console.ReadLine();
                        consultaNombre = consultaBase + " NombreUsuario = '" + nombre + "' WHERE IdUsuario = " + id;
                        break;
                    case 3:
                        Console.WriteLine("Inserta la contrasenia, por favor:");
                        contrasenia = Console.ReadLine();
                        consultaContrasenia = consultaBase + " Contrasenia = '" + contrasenia + "' WHERE IdUsuario = " + id;
                        break;
                    case 4:
                        Console.WriteLine("Inserta el saldo, por favor:");
                        saldo = double.Parse(Console.ReadLine());
                        consultaSaldo = consultaBase + " Saldo = " + saldo + " WHERE IdUsuario = " + id;
                        break;
                    default:
                        Console.WriteLine("Una opción de la lista!!");
                        break;
                }
                Console.WriteLine("¿Qué quieres actualizar?\n 1)Email\n 2)NombreUsuario\n 3)Contrasenia\n 4)Saldo\n 0)Salir");
                opc = int.Parse(Console.ReadLine());

            } while (opc != 0);
            
            Console.WriteLine(consultaEmail);
            Console.WriteLine(consultaNombre);
            Console.WriteLine(consultaContrasenia);
            Console.WriteLine(consultaSaldo);
            {
                
                OleDbCommand comandoEmail = new OleDbCommand(consultaEmail, conexion);
                OleDbCommand comandoNombre = new OleDbCommand(consultaNombre, conexion);
                OleDbCommand comandoContrasenia = new OleDbCommand(consultaContrasenia, conexion);
                OleDbCommand comandoSaldo = new OleDbCommand(consultaSaldo, conexion);
                    
                try
                {
                        
                    conexion.Open();
                    
                    if (consultaEmail != "")
                    {
                        OleDbDataReader miTabla = comandoEmail.ExecuteReader();
                    }
                    if (consultaNombre != "")
                    {
                        OleDbDataReader miTabla = comandoNombre.ExecuteReader();
                    }
                    if (consultaContrasenia != "")
                    {
                        OleDbDataReader miTabla = comandoContrasenia.ExecuteReader();
                    }
                    if (consultaSaldo != "")
                    {
                        OleDbDataReader miTabla = comandoSaldo.ExecuteReader();
                    }

                    Console.WriteLine("Actualizado correctamente");
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

		public void actualizarPrecioObjeto()
		{
			int idObj;
			double precio = 0;
			string consultaBase = "UPDATE objeto SET  ";
			string consultaPrecio = "";
			Console.WriteLine("¿A qué Objeto quieres actualizar el precio (escriba el id por favor)?");
			idObj = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Inserta el nuevo precio, por favor:");
			precio = double.Parse(Console.ReadLine());
			consultaPrecio = consultaBase + " Precio = " + precio + " WHERE IdObjeto = " + idObj;		
            
			Console.WriteLine(consultaPrecio);
			{

				OleDbCommand comandoPrecio = new OleDbCommand(consultaPrecio, conexion);
                
				try
				{   
					conexion.Open();

					if (consultaPrecio != "")
					{
						OleDbDataReader miTabla = comandoPrecio.ExecuteReader();
					}

					Console.WriteLine("Actualizado correctamente");
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

		public void vaciarCarrito()
		{
			string consulta = "DELETE * FROM carrito ";
            
			{

				OleDbCommand comando = new OleDbCommand(consulta, conexion);

				try
				{
					conexion.Open();

					OleDbDataReader miTabla = comando.ExecuteReader();

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
