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
    class Principal
    {
        //Conexion conexion =  new Conexion();
        public static void menuLogin()
        {
            Validations validate = new Validations();

            int opcionMenuLogin = 0;

            do
            {
                Console.WriteLine("Este es un menu de login de prueba:");
                Console.WriteLine("1) Iniciar sesion");
                Console.WriteLine("2) Registrarse");
                Console.WriteLine("3) Iniciar sesion sin registro");
                Console.WriteLine("0) Salir del programa");

                Console.WriteLine("Introduzca una opcion: ");
                opcionMenuLogin = validate.ReadInt();

                switch (opcionMenuLogin)
                {
                    case 1:
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Conexion.insertarUsuarioEnBD();
                        break;
                    case 3:
                        Console.Clear();
                        menuUsuario();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Escoja una opción válida, por favor.");
                        Console.Read();
                        break;
                }
            } while (opcionMenuLogin != 0);
        }

        public static void menuUsuario()
        {

            int opcionMenuUsuario = 0;
            double precioTotalCarrito = 0;
            Usuario actualUser = new Usuario();
            Objeto objetoCarrito = new Objeto(); 
            Validations validate = new Validations();

            do
            {
                Console.WriteLine("Este es un menu de usuario de prueba:");
                Console.WriteLine("1) Vender");
                Console.WriteLine("2) Añadir al carrito");
                Console.WriteLine("3) Chatear con otros usuarios");
                Console.WriteLine("4) Hacer una oferta");
                Console.WriteLine("5) Añadir a favoritos");
                Console.WriteLine("6) Filtrar por categoria");
                Console.WriteLine("7) Menu carrito de compra");
                Console.WriteLine("0) Volver al menu Login");

                Console.WriteLine("Introduzca una opcion: ");
                opcionMenuUsuario = validate.ReadInt();

                switch (opcionMenuUsuario)
                {
                    case 1:
                        //Cambiar por el Id del usuario del momento
                        Console.Clear();
                        Conexion.insertarObjetoEnBD(actualUser.Id);
                        break;
                    case 2:
                        //Cambiar por el objeto enviado por el objeto seleccionado
                        Console.Clear();
                        precioTotalCarrito += objetoCarrito.Precio;
                        Conexion.aniadirObjetoCarrito(actualUser.Id, objetoCarrito, precioTotalCarrito);
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    case 7:
                        Console.Clear();
                        menuCarrito();
                        break;
                    case 0:
                        Console.Clear();
                        menuLogin();
                        break;
                    default:
                        Console.WriteLine("Escoja una opción válida, por favor.");
                        validate.ReadInt();
                        break;
                }
            } while (opcionMenuUsuario != 0);


        }

        public static void menuCarrito()
        {
            Validations validate = new Validations();

            int opcionMenuCarrito = 0;

            do
            {
                Console.WriteLine("Este es un menu de carrito de prueba:");
                Console.WriteLine("1) Cambiar precio");
                Console.WriteLine("2) Confirmar compra");
                Console.WriteLine("3) Vaciar carrito de compra");
                Console.WriteLine("0) Volver al menu Usuario");

                Console.WriteLine("Introduzca una opcion: ");
                opcionMenuCarrito = validate.ReadInt();

                switch (opcionMenuCarrito)
                {
                    case 1:
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    case 0:
                        Console.Clear();
                        menuUsuario();
                        break;
                    default:
                        Console.WriteLine("Escoja una opción válida, por favor.");
                        validate.ReadInt();
                        break;
                }
            } while (opcionMenuCarrito != 0);
        }

        static void Main(string[] args)
        {
            Validations validate = new Validations();

            int opcionMenuGeneral = 0;

            do
            {
                Console.WriteLine("A que menú desea acceder?:");
                Console.WriteLine("1) Menu Login");
                Console.WriteLine("2) Menu BD");
                Console.WriteLine("0) Salir del programa");

                Console.WriteLine("Introduzca una opcion: ");
                opcionMenuGeneral = validate.ReadInt();

                switch (opcionMenuGeneral)
                {
                    case 1:
                        Console.Clear();
                        menuLogin();
                        break;
                    case 2:
                        Console.Clear();
                        Conexion.MenuBD();
                        break;
                    case 0:
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Escoja una opción válida, por favor.");
                        validate.ReadInt();
                        break;
                }
            } while (opcionMenuGeneral != 0);
        }
    }
}
