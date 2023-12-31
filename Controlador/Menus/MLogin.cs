﻿using ProyectoPersonal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controlador.Menus
{
    public class MLogin
    {
        static Conexion cnn = new Conexion();
        public static void MenuLogin()
        {
            Validations validate = new Validations();
            GestorUsuarios GU = new GestorUsuarios();
            int idUsuarioActivo;

            int opcionMenuLogin = 0;

            do
            {
                Console.WriteLine("Este es un menu de login de prueba:");
                Console.WriteLine("1) Iniciar sesion");
                Console.WriteLine("2) Registrarse");
                Console.WriteLine("0) Salir del programa");

                Console.WriteLine("Introduzca una opcion: ");
                opcionMenuLogin = validate.ReadInt();

                switch (opcionMenuLogin)
                {
                    case 1:
                        Console.Clear();
                        GU.IniciarSesion();
						break;
                    case 2:
                        Console.Clear();
                        GU.Registrarse();
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

    }
}
