using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controlador.Menus
{
    public class MCarrito
    {
        public static void MenuCarrito()
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
                        //falta, seria un update
                        break;
                    case 2:
                        Console.Clear();
                        //falta, seria un delete del objeto en carrito y un update en el saldo del usuario
                        break;
                    case 3:
                        Console.Clear();
                        //falta, seria un delete de los objetos del carrito
                        break;
                    case 0:
                        Console.Clear();
                        MUsuario.MenuUsuario();
                        break;
                    default:
                        Console.WriteLine("Escoja una opción válida, por favor.");
                        validate.ReadInt();
                        break;
                }
            } while (opcionMenuCarrito != 0);
        }

    }
}
