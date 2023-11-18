using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Modelo.interfaces
{
    public interface IMetodosConexion
    {
        public void LeerObjetosDeUsuario(int idUser);
        public void ExplorarObjetos();
        public double ConsultarSaldo(int idUser);
        public void VerCarrito(int idUser);
        public List<int> ListaObjetosCarrito(int idUser);
        public void PrecioCarrito(int idUser);
        public List<int> IdVendedor(int idUser);
        public List<double> PrecioObjetoCarrito(int idUser);
	}
}
