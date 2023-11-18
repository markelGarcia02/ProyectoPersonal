using ProyectoPersonal.Data;
using ProyectoPersonal.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controlador.Menus
{
    public class MUsuario
    {
        static Conexion cnn = new Conexion();
        static Inserts ins = new Inserts();
        public static void MenuUsuario(int idActivo)
        {

            int opcionMenuUsuario = 0;
            Validations validate = new Validations();

            do
            {
                Console.WriteLine("Este es un menu de usuario de prueba:");
                Console.WriteLine("1) Explorar Objetos");
                Console.WriteLine("2) Consultar saldo");
                Console.WriteLine("3) Ver carrito");
                Console.WriteLine("4) Ver mis objetos en venta");
                Console.WriteLine("5) Vender un objeto");
                Console.WriteLine("6) Comprar un objeto");
                Console.WriteLine("0) Volver al menu Login");
                Console.WriteLine("Introduzca una opcion: ");
                opcionMenuUsuario = validate.ReadInt();

                switch (opcionMenuUsuario)
                {
                    case 1:
                        Console.Clear();
                        cnn.ExplorarObjetos();
                        break;
                    case 2:
						Console.Clear();
                        cnn.ConsultarSaldo(idActivo);
                        break;
                    case 3:
						Console.Clear();
                        cnn.VerCarrito(idActivo);
                        cnn.PrecioCarrito(idActivo);
                        MCarrito.MenuCarrito(idActivo);
                        break;
                    case 4:
						Console.Clear();
                        cnn.LeerObjetosDeUsuario(idActivo);
                        break;
                    case 5:
						Console.Clear();
						ins.InsertarObjeto(idActivo);
                        break;
                    case 6:
						Console.Clear();
						ins.InsertarObjetoCarrito(idActivo);
                        MCarrito.MenuCarrito(idActivo);
                        break;
                    case 0:
                        Console.Clear();
                        idActivo = -1;
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
