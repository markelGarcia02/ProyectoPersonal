using ProyectoPersonal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controlador.Menus
{
    public class MCarrito
    {
		static Conexion cnn = new Conexion();
        static Deletes del = new Deletes();
		static GestorCompras gc = new GestorCompras();
		public static void MenuCarrito(int idActivo)
        {
            Validations validate = new Validations();

            int opcionMenuCarrito = 0;

            do
            {
                Console.WriteLine("Este es un menu de carrito de prueba:");
                Console.WriteLine("1) Confirmar compra");
                Console.WriteLine("2) Cancelar compra");
                Console.WriteLine("0) Volver al menu Usuario");

                Console.WriteLine("Introduzca una opcion: ");
                opcionMenuCarrito = validate.ReadInt();

                switch (opcionMenuCarrito)
                {
                    case 1:
						Console.Clear();
                        
                        List<double> precioObjetoCarrito = new List<double>();
                        precioObjetoCarrito = cnn.PrecioObjetoCarrito(idActivo);
                        
						List<int> IdVendedores = new List<int>();
						IdVendedores = cnn.IdVendedor(idActivo);
						
                        for (int i = 0; i < IdVendedores.Count; i++)
						{
                            gc.SumarDineroVendedor(IdVendedores[i], precioObjetoCarrito[i]);
                            gc.RestarDineroComprador(idActivo, precioObjetoCarrito[i]);
						}

						List<int> ListaObjetos = new List<int>();
						ListaObjetos = cnn.ListaObjetosCarrito(idActivo);
						for (int i = 0; i < ListaObjetos.Count; i++)
						{
							del.BorrarObjeto(ListaObjetos[i]);
						}

						del.BorrarCarrito(idActivo);
						break;
                    case 2:
						Console.Clear();
						del.BorrarCarrito(idActivo);
                        break;
                    case 0:
                        Console.Clear();
                        MUsuario.MenuUsuario(idActivo);
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
