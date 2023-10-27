using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPersonal.Controlador;

namespace ProyectoPersonal.Modelo
{
    public class Objeto : GestorObjetos
    {
        private double precio;
        private string titulo;
        private string descripcion;
        private string foto;
        private int idObjeto;

        public Objeto(double precio, string titulo, string descripcion, string foto)
        {
            Precio = precio;
            Titulo = titulo;
            Descripcion = descripcion;
            Foto = foto;
        }

        public Objeto(int idObjeto)
        {
            idObjeto = idObjeto;
        }

        public Objeto() { }

        public double Precio { get => precio; set => precio = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Foto { get => foto; set => foto = value; }
        public int IdObjeto { get => idObjeto; set => idObjeto = value; }
    }
}
