using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPersonal.Controlador.Menus;
using ProyectoPersonal.Data;
using ProyectoPersonal.Modelo;

namespace ProyectoPersonal.Controlador
{
    public class GestorUsuarios
    {
        Validations validator = new Validations();
		static Conexion cnn = new Conexion();
		static Sesion ses = new Sesion();
		static Inserts ins = new Inserts();

		public void IniciarSesion()
        {
            List<string> userNames = new List<string>();
			List<string> Passwords = new List<string>();
			string name, pass, coincideName, coincidePass;
			bool coincideUser = false;
			bool coincidenAmbas = false;
            int idActivo;
			int n = 0;

			userNames = ses.LeerUserName();
			Passwords = ses.LeerPassword();
			
			do
			{
				Console.WriteLine("Introduzca el nombre de usuario, por favor");
				name = Console.ReadLine();
				Console.WriteLine("Introduzca la constraseña del usuario, por favor");
				pass = Console.ReadLine();

				for (int i = 0; i < userNames.Count; i++)
				{
					if (userNames[i].Contains(name))
					{
						coincideUser = true;
						n = i;
					}
				}
				if (coincideUser == true)
				{
					if (Passwords[n].Contains(pass))
					{
						coincidenAmbas = true;
					}
					else
					{
						Console.Clear();
						Console.WriteLine("La contraseña es incorrecta");
					}
				}
				else
				{
					Console.Clear();
					Console.WriteLine("El usuario no existe");
				}
				if (coincidenAmbas == true)
				{
					idActivo = ses.SacarIdActivoPass(pass);
					MUsuario.MenuUsuario(idActivo);
				}
			} while (coincidenAmbas != true);
        }

        public void Registrarse()
        {
            string userActivo = ins.InsertarUsuario();
            int idActivo = ses.SacarIdActivoUser(userActivo);
			MUsuario.MenuUsuario(idActivo);
		}
    }
}
