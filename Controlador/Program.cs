using ProyectoPersonal.Controlador.Menus;
using ProyectoPersonal.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controlador
{
    public class Program
    {
		static Conexion cnn = new Conexion();
		static void Main(string[] args)
        {

			MLogin.MenuLogin();

		}
	}
}
