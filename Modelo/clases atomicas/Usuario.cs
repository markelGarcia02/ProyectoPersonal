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
        private int idUser; 
        private string email;
        private string userName;
		private string lastName;
		private string password;
        private double saldo;

        public Usuario(int idUser, string email, string userName, string lastName, string password, double saldo)
        {
            IdUser = idUser;
            Email = email;
			UserName = userName;
            LastName = lastName;
            Password = password;
            Saldo = saldo;
        }

        public Usuario( string email, string userName, string lastName, string password, double saldo)
        {
            Email = email;
			UserName = userName;
			LastName = lastName;
			Password = password;
            Saldo = saldo;
        }

        public Usuario() { }

        public Usuario(int id)
        {
			IdUser = idUser;
        }

        public int IdUser { get => idUser; set => idUser = value; }
        public string Email { get => email; set => email = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public double Saldo { get => saldo; set => saldo = value; }
		public string LastName { get => lastName; set => lastName = value; }
	}
}
