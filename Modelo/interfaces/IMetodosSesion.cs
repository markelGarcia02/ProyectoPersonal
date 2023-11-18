using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Modelo.interfaces
{
	public interface IMetodosSesion
	{
		public List<string> LeerUserName();
		public List<string> LeerPassword();
		public int SacarIdActivoPass(string pass);
		public int SacarIdActivoUser(string user);
	}
}
