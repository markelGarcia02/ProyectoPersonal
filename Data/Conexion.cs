using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using ProyectoPersonal.Modelo;

namespace ProyectoPersonal.Data
{
    class Conexion
    {

        static public void leerUsuariosBD()
        {
            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markgarcia\source\repos\ProyectoPersonal\ProyectoPersonalMarkel.mdb";
            string consulta = "SELECT * FROM usuario";
            // Create a connection    
            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {
                // Create a command and set its connection    
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                // Open the connection and execute the select command.    
                try
                {
                    // Open connecton    
                    conexion.Open();
                    // Execute command    
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

        static public void leerObjetosBD()
        {
            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markgarcia\source\repos\ProyectoPersonal\ProyectoPersonalMarkel.mdb";
            string consulta = "SELECT * FROM objeto";
            // Create a connection    
            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {
                // Create a command and set its connection    
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                // Open the connection and execute the select command.    
                try
                {
                    // Open connecton    
                    conexion.Open();
                    // Execute command    
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

        static public void eliminarUsuarioDeDB()
        {
            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markgarcia\source\repos\ProyectoPersonal\ProyectoPersonalMarkel.mdb";
            string consulta = "DELETE FROM usuario WHERE IdUsuario=";
            int id;

            Console.WriteLine("¿Qué id quieres eliminar?");
            id = int.Parse(Console.ReadLine());
            consulta = consulta + id;

            // Create a connection    
            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {
                // Create a command and set its connection    
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                // Open the connection and execute the select command.    
                try
                {
                    // Open connecton    
                    conexion.Open();
                    // Execute command    

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

        static public void eliminarObjetoDeDB()
        {
            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markgarcia\source\repos\ProyectoPersonal\ProyectoPersonalMarkel.mdb";
            string consulta = "DELETE FROM objeto WHERE IdObjeto=";
            int id;

            Console.WriteLine("¿Qué id quieres eliminar?");
            id = int.Parse(Console.ReadLine());
            consulta = consulta + id;

            // Create a connection    
            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {
                // Create a command and set its connection    
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                // Open the connection and execute the select command.    
                try
                {
                    // Open connecton    
                    conexion.Open();
                    // Execute command    

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
        static public void insertarUsuarioEnBD()
        {
            //La ruta de la BD
            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markgarcia\source\repos\ProyectoPersonal\ProyectoPersonalMarkel.mdb";
            //Leemos lo que vamos a insertar
            Console.WriteLine("Inserta un email, por favor:");
            string email = Console.ReadLine();
            Console.WriteLine("Inserta un nombre, por favor:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Inserta una contrasenia, por favor:");
            string contrasenia = Console.ReadLine();
            Console.WriteLine("Inserta un saldo, por favor:");
            int saldo = int.Parse(Console.ReadLine());

            //Preparamos la query(consulta)
            string consulta = "INSERT INTO usuario(Email, NombreUsuario, Contrasenia, Saldo) VALUES ('" + email + "','" + nombre + "','" + contrasenia + "'," + saldo + ")";
            Console.WriteLine(consulta);
            // Create a connection    
            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {
                // Create a command and set its connection    
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                // Open the connection and execute the select command.    
                try
                {
                    // Open connecton    
                    conexion.Open();
                    // Execute command    
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

        static public void insertarObjetoEnBD(int idUser)
        {
            //La ruta de la BD
            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markgarcia\source\repos\ProyectoPersonal\ProyectoPersonalMarkel.mdb";
            //Leemos lo que vamos a insertar
            Console.WriteLine("Inserta un titulo, por favor:");
            string titulo = Console.ReadLine();
            Console.WriteLine("Inserta una descripcion, por favor:");
            string descripcion = Console.ReadLine();
            Console.WriteLine("Inserta una foto, por favor:");
            string foto = Console.ReadLine();
            Console.WriteLine("Inserta un precio, por favor:");
            double precio = int.Parse(Console.ReadLine());
            int idUsuario = idUser;

            //Preparamos la query(consulta)
            string consulta = "INSERT INTO objeto(Titulo, Descripcion, Foto, Precio, IdUsuario) VALUES ('" + titulo + "','" + descripcion + "','" + foto + "'," + precio + "," + idUsuario + ")";
            Console.WriteLine(consulta);
            // Create a connection    
            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {
                // Create a command and set its connection    
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                // Open the connection and execute the select command.    
                try
                {
                    // Open connecton    
                    conexion.Open();
                    // Execute command    
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

        static public void aniadirObjetoCarrito(int idUser, Objeto obj, double totalPrecio)
        {
            //La ruta de la BD
            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markgarcia\source\repos\ProyectoPersonal\ProyectoPersonalMarkel.mdb";
            //Leemos lo que vamos a insertar
            int idUsuario = idUser;
            int idObjeto = obj.IdObjeto;

            //Preparamos la query(consulta)
            string consulta = "INSERT INTO carrito(IdUsuario, IdObjeto, TotalPrecio) VALUES (" + idUsuario + "," + idObjeto + "," + totalPrecio + ")";
            Console.WriteLine(consulta);
            // Create a connection    
            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {
                // Create a command and set its connection    
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                // Open the connection and execute the select command.    
                try
                {
                    // Open connecton    
                    conexion.Open();
                    // Execute command    
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

        static public void actualizarUsuarioEnBD()
        {
            //La ruta de la BD
            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markgarcia\source\repos\ProyectoPersonal\ProyectoPersonalMarkel.mdb";
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
                        //Leemos lo que vamos a insertar
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

            //Ver consulta
            Console.WriteLine(consultaEmail);
            Console.WriteLine(consultaNombre);
            Console.WriteLine(consultaContrasenia);
            Console.WriteLine(consultaSaldo);
            // Create a connection    
            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {
                // Create a command and set its connection    
                OleDbCommand comandoEmail = new OleDbCommand(consultaEmail, conexion);
                OleDbCommand comandoNombre = new OleDbCommand(consultaNombre, conexion);
                OleDbCommand comandoContrasenia = new OleDbCommand(consultaContrasenia, conexion);
                OleDbCommand comandoSaldo = new OleDbCommand(consultaSaldo, conexion);
                // Open the connection and execute the select command.    
                try
                {
                    // Open connecton    
                    conexion.Open();
                    // Execute command
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

        static public void MenuBD()
        {
            int opc;
            Console.WriteLine("¿Qué quieres hacer?\n 1) Leer usuario en BD\n 2) Leer objeto en BD\n 3) Actualizar usuario en BD\n 4) Eliminar usuario en DB\n 5) Eliminar objeto en DB\n 6) Insertar usuario en DB\n 0) Salir");
            opc = int.Parse(Console.ReadLine());
            do
            {
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        leerUsuariosBD();
                        break;
                    case 2:
                        Console.Clear();
                        leerObjetosBD();
                        break;
                    case 3:
                        Console.Clear();
                        actualizarUsuarioEnBD();
                        break;
                    case 4:
                        Console.Clear();
                        eliminarUsuarioDeDB();
                        break;
                    case 5:
                        Console.Clear();
                        eliminarObjetoDeDB();
                        break;
                    case 6:
                        Console.Clear();
                        insertarUsuarioEnBD();
                        break;
                    case 0:
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Una opción de la lista!!");
                        break;
                }
                Console.WriteLine("¿Qué quieres hacer?\n 1) Leer usuario en BD\n 2) Leer objeto en BD\n 3) Actualizar usuario en BD\n 4) Eliminar usuario en DB\n 5) Eliminar objeto en DB\n 6) Insertar usuario en DB\n 0) Salir");
                opc = int.Parse(Console.ReadLine());

            } while (opc != 0);
        }
    }
}
