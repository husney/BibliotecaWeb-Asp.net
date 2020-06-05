using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Sesion
	{
		private String usuario;
		private String contraseña;
		private int idCuenta;

		public Sesion() { }

		public Sesion(String usuario, String contraseña)
		{
			this.usuario = usuario;
			this.contraseña = contraseña;
		}

		public Sesion(String usuario, String contraseña, int idCuenta)
		{
			this.usuario = usuario;
			this.contraseña = contraseña;
			this.idCuenta = idCuenta;
		}

		public String Usuario { get { return this.usuario; } set { this.usuario = value; } }
		public String Contraseña { get { return this.contraseña; } set { this.contraseña = value; } }
		public int IdCuenta { get { return this.idCuenta; } set { this.idCuenta = value; } }

	}
}
