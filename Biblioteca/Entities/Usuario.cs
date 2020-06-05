using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Usuario
	{
		private String documento;
		private String nombre;
		private String direccion;
		private String telefono;
		private String correo;
		private String estado;
		private int id;

		public Usuario() { }

		public Usuario(String documento, String nombre, String direccion, String telefono, String correo, String estado)
		{
			this.documento = documento;
			this.nombre = nombre;
			this.direccion = direccion;
			this.telefono = telefono;
			this.correo = correo;
			this.estado = estado;
		}

		public Usuario(String documento, String nombre, String direccion, String telefono, String correo, String estado, int id)
		{
			this.documento = documento;
			this.nombre = nombre;
			this.direccion = direccion;
			this.telefono = telefono;
			this.correo = correo;
			this.estado = estado;
			this.id = id;
		}

		public String Documento { get { return this.documento; } set { this.documento = value; } }
		public String Nombre { get { return this.nombre; } set { this.nombre = value; } }
		public String Direccion { get { return this.direccion; } set { this.direccion = value; } }
		public String Telefono { get { return this.telefono; } set { this.telefono = value; } }
		public String Correo { get { return this.correo; } set { this.correo = value; } }
		public String Estado { get { return this.estado; } set { this.estado = value; } }
		public int Id { get { return this.id; } set { this.id = value; } }
	}
}
