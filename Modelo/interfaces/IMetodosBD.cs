using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Modelo.interfaces
{
    public interface IMetodosBD
    {
        public void leerUsuariosBD();
        public void leerObjetosBD();
        public void eliminarUsuarioDeDB();
        public void eliminarObjetoDeDB();
        public void insertarUsuarioEnBD();
        public void insertarObjetoEnBD(int idUser);
        public void aniadirObjetoCarrito(int idUser, Objeto obj, double totalPrecio);
        public void actualizarUsuarioEnBD();
    }
}
