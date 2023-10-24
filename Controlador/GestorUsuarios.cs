using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPersonal.Modelo;

namespace ProyectoPersonal.Controlador
{
    abstract class GestorUsuarios
    {
        Validations validator = new Validations();
        private List<Usuario> users = new List<Usuario>();
        private List<Mensaje> mensajes = new List<Mensaje>();
        //iniciarSesion() //hacer con ficheros

        public GestorUsuarios()
        {

        }
        public void register()
        {
            string newEmail = "";
            string newUserName = "";
            string newPassword = "";
            double newSaldo = 0;

            Console.WriteLine("Por favor introduzca un email: ");
            newEmail = validator.ReadString();
            Console.WriteLine("Por favor introduzca un nombre de usuario: ");
            newUserName = validator.ReadString();
            Console.WriteLine("Por favor introduzca una contraseña: ");
            newPassword = validator.ReadString();
            Console.WriteLine("Por favor introduzca el saldo disponible: ");
            newSaldo = validator.ReadDouble();
            Usuario user = new Usuario(newEmail, newUserName, newPassword, newSaldo);

            users.Add(user);
            
        }


        public void chatear(Mensaje msg)
        {
            string m = "";
            int idMensaje = 0;
            Console.WriteLine("Introduzca el mensaje que quiera enviar al otro usuario");
            m = validator.ReadString();
            msg.Mensajes[idMensaje] = m;
            mensajes.Add(msg);
            idMensaje++;
        }
    }
}
