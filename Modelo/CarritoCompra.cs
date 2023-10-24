using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPersonal.Controlador;

namespace ProyectoPersonal.Modelo
{
    class CarritoCompra : GestorCompras
    {
        private CarritoCompra[] compras = new CarritoCompra[0];

        public CarritoCompra(CarritoCompra[] compras)
        {
            Compras = compras;
        }

        CarritoCompra[] Compras { get => compras; set => compras = value; }
    }
}
