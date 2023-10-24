using ProyectoPersonal.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controlador
{
    abstract class GestorCompras
    {
        //finalizarCompra()
        private List<Objeto> carrito = new List<Objeto>();
        Validations validator = new Validations();

        public void pujar(Objeto newObj)
        {
            double precioObj = newObj.Precio;
            Console.WriteLine("El precio del objeto sobre el que quiere hacer la puja es: " + precioObj);
            Console.WriteLine("Introduzca su oferta: ");
            double puja = validator.ReadDouble();
            Console.WriteLine("Puja realizada por el valor de: " + puja);
        }

        public void aniadirCarrito(Objeto newObj)
        {
            carrito.Add(newObj);
        }

        public void vaciarCarrito()
        {
            if (carrito.Count > 0)
            {
                carrito.RemoveAll( carrito => carrito.Precio > 0 );
            }
        }
    }
}
