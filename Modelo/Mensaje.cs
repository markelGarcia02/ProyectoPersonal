using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Modelo
{
    class Mensaje
    {
        private string[] mensajes = { };
        private int idAutor;

        public Mensaje(string[] mensajes)
        {
            this.mensajes = mensajes;
        }

        public Mensaje(int idAutor)
        {
            this.idAutor = idAutor;
        }

        public string[] Mensajes { get => mensajes; set => mensajes = value; }
        public int IdAutor { get => idAutor; set => idAutor = value; }
    }
}
