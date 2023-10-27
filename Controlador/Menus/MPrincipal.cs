using ProyectoPersonal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controlador.Menus
{
    public class MPrincipal
    {
        public static void MenuPrincipal()
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
                        MLogin.MenuLogin();
                        break;
                    case 2:
                        Console.Clear();
                        MBaseDatos.MenuBD();
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
