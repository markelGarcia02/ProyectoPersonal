using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPersonal.Modelo;

namespace ProyectoPersonal.Controlador
{
    abstract class GestorObjetos
    {
        Validations validator = new Validations();
        private List<Objeto> objs = new List<Objeto>();
        //esFavorito()
        //filtrarPorCategoria()

        public double cambiarPrecio(Objeto newObj)
        {
            Console.WriteLine("Introduzca el nuevo precio del producto: ");
            double newPrecio = validator.ReadDouble();
            return newObj.Precio = newPrecio;
        }

        public void vender()
        {
            double newPrecio = 0;
            string newTitulo = "";
            string newDescripcion = "";
            string newFoto = "";

            Console.WriteLine("Por favor introduzca el precio del objeto: ");
            newPrecio = validator.ReadDouble();
            Console.WriteLine("Por favor introduzca el nombre del objeto: ");
            newTitulo = validator.ReadString();
            Console.WriteLine("Por favor introduzca una descripcion para el objeto: ");
            newDescripcion = validator.ReadString();
            Console.WriteLine("Por favor introduzca una foto del objeto: ");
            newFoto = validator.ReadString();
            Objeto newObj = new Objeto(newPrecio, newTitulo, newDescripcion, newFoto);

            objs.Add(newObj);
        }
    }
}
