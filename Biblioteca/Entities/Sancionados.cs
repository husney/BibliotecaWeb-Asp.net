using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Sancionados
	{

		

		private String usuario;
		private String nombre;
		private String direccion;
		private String telefono;
		private String correo;
		private String estado;
		private int id;
		private String codigoPrestamo;
		private String libro;
		private int diasSancion;
		private int cantidad;

		public Sancionados() { }

		public Sancionados(String usuario, String nombre, String direccion, String telefono, String correo, String estado, int id, String codigoPrestamo, String libro, int diasSancion, int cantidad)
		{
			this.usuario = usuario;
			this.nombre = nombre;
			this.direccion = direccion;
			this.telefono = telefono;
			this.correo = correo;
			this.estado = estado;
			this.id = id;
			this.codigoPrestamo = codigoPrestamo;
			this.libro = libro;
			this.diasSancion = diasSancion;
			this.cantidad = cantidad;
		}

		public string Usuario { get => usuario; set => usuario = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public string Direccion { get => direccion; set => direccion = value; }
		public string Telefono { get => telefono; set => telefono = value; }
		public string Correo { get => correo; set => correo = value; }
		public string Estado { get => estado; set => estado = value; }
		public int Id { get => id; set => id = value; }
		public string CodigoPrestamo { get => codigoPrestamo; set => codigoPrestamo = value; }
		public string Libro { get => libro; set => libro = value; }
		public int DiasSancion { get => diasSancion; set => diasSancion = value; }
		public int Cantidad { get => cantidad; set => cantidad = value; }
	}
}
