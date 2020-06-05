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
		private int prestamo;
		private int diasSansion;
		private String fechaInicio;
		private String fechaFin;
		private String libro;
		private int cantidad;
		private String fechaDevolucion;

		public DetallePrestamos() { }

		public DetallePrestamos(int codigo, int prestamo, int diasSansion, String fechaInicio, String fechaFin, String libro, int cantidad, String fechaDevolucion)
		{
			this.codigo = codigo;
			this.prestamo = prestamo;
			this.diasSansion = diasSansion;
			this.fechaInicio = fechaInicio;
			this.fechaFin = fechaFin;
			this.libro = libro;
			this.cantidad = cantidad;
			this.fechaDevolucion = fechaDevolucion;
		}

		public int Codigo { get { return this.codigo; } set { this.codigo = value; } }
		public int Prestamo { get { return this.prestamo; } set { this.prestamo = value; } }
		public int DiasSansion { get { return this.diasSansion; } set { this.diasSansion = value; } }
		public String FechaInicio { get { return this.fechaInicio; } set { this.fechaInicio = value; } }
		public String FechaFin { get { return this.fechaFin; } set { this.fechaFin = value; } }
		public String Libro { get { return this.libro; } set { this.libro = value; } }
		public int Cantidad { get { return this.cantidad; } set { this.cantidad = value; } }
		public String FechaDevolucion { get { return this.fechaDevolucion; } set { this.fechaDevolucion = value; } }

	}
}
