using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPersonal.Controlador;

namespace ProyectoPersonal.Modelo
{
    public class Usuario : GestorUsuarios
    {
        private int id; 
        private string email;
        private string nombreUsuario;
        private string password;
        private double saldo;

        public Usuario(int id, string email, string nombreUsuario, string password, double saldo)
        {
            Id = id;
            Email = email;
            NombreUsuario = nombreUsuario;
            Password = password;
            Saldo = saldo;
        }

        public Usuario( string email, string nombreUsuario, string password, double saldo)
        {
            Email = email;
            NombreUsuario = nombreUsuario;
            Password = password;
            Saldo = saldo;
        }

        public Usuario() { }

        public Usuario(int id)
        {
            Id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public double Saldo { get => saldo; set => saldo = value; }

    }
}
