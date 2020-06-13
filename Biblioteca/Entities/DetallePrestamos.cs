using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class DetallePrestamos
	{
		private int codigo;
		private String usuario;
		private String libro;
		private String fechaInicio;
		private String fechaFin;
		private int diasSancion;
		private int cantidad;


		public DetallePrestamos() { }

		public DetallePrestamos(int codigo, String usuario, String libro, String fechaInicio, String fechaFin, int diasSancion, int cantidad)
		{
			this.codigo = codigo;
			this.usuario = usuario;
			this.libro = libro;
			this.fechaInicio = fechaInicio;
			this.fechaFin = fechaFin;
			this.diasSancion = diasSancion;
			this.cantidad = cantidad;
		}


		public DetallePrestamos( String usuario, String libro, String fechaInicio, String fechaFin, int diasSancion, int cantidad)
		{
			this.usuario = usuario;
			this.libro = libro;
			this.fechaInicio = fechaInicio;
			this.fechaFin = fechaFin;
			this.diasSancion = diasSancion;
			this.cantidad = cantidad;
		}

		public int Codigo { get => codigo; set => codigo = value; }
		public string Usuario { get => usuario; set => usuario = value; }
		public string Libro { get => libro; set => libro = value; }
		public string FechaInicio { get => fechaInicio; set => fechaInicio = value; }
		public string FechaFin { get => fechaFin; set => fechaFin = value; }
		public int DiasSancion { get => diasSancion; set => diasSancion = value; }
		public int Cantidad { get => cantidad; set => cantidad = value; }
	}

}
