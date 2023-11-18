using ProyectoPersonal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controlador.Menus
{
    public class MBaseDatos 
    {
        static Conexion cnn = new Conexion();
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
                        //cnn.LeerUsuariosBD();
                        break;
                    case 2:
                        Console.Clear();
                        //cnn.leerObjetosBD();
                        break;
                    case 3:
                        Console.Clear();
                        //cnn.actualizarUsuarioEnBD();
                        break;
                    case 4:
                        Console.Clear();
                        //cnn.eliminarUsuarioDeDB();
                        break;
                    case 5:
                        Console.Clear();
                        //cnn.eliminarObjetoDeDB();
                        break;
                    case 6:
                        Console.Clear();
                        //cnn.insertarUsuarioEnBD();
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
