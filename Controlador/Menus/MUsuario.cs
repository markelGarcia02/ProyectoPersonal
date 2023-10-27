using ProyectoPersonal.Data;
using ProyectoPersonal.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controlador.Menus
{
    public class MUsuario
    {
        static Conexion cnn = new Conexion();
        public static void MenuUsuario()
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
                        cnn.insertarObjetoEnBD(actualUser.Id);
                        break;
                    case 2:
                        //Cambiar por el objeto enviado por el objeto seleccionado
                        Console.Clear();
                        precioTotalCarrito += objetoCarrito.Precio;
                        cnn.aniadirObjetoCarrito(actualUser.Id, objetoCarrito, precioTotalCarrito);
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
                        MCarrito.MenuCarrito();
                        break;
                    case 0:
                        Console.Clear();
                        MLogin.MenuLogin();
                        break;
                    default:
                        Console.WriteLine("Escoja una opción válida, por favor.");
                        validate.ReadInt();
                        break;
                }
            } while (opcionMenuUsuario != 0);
        }

    }
}
