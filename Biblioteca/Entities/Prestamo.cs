using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	class Prestamo
	{
		private int codigo;
		private String fecha;
		private String usuario;

		public Prestamo() { }

		public Prestamo(int codigo, String fecha, String usuario)
		{
			this.codigo = codigo;
			this.fecha = fecha;
			this.usuario = usuario;
		}	

		public int Codigo { get { return this.codigo; } set { this.codigo = value; } }
		public String Fecha { get { return this.fecha; } set { this.fecha = value; } }
		public String Usuario { get { return this.usuario; } set { this.usuario = value; } }
	}
}
