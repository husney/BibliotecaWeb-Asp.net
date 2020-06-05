using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Libro
	{
		private String codigo;
		private String nombre;
		private int numeroPaginas;
		private String autor;
		private String editorial;
		private String area;
		private int id;

		public Libro() { }

		public Libro(String codigo, String nombre, int numeroPaginas, String autor, String editorial, String area)
		{
			this.codigo = codigo;
			this.nombre = nombre;
			this.numeroPaginas = numeroPaginas;
			this.autor = autor;
			this.editorial = editorial;
			this.area = area;
			
		}

		public Libro(String codigo, String nombre, int numeroPaginas, String autor, String editorial, String area, int id)
		{
			this.codigo = codigo;
			this.nombre = nombre;
			this.numeroPaginas = numeroPaginas;
			this.autor = autor;
			this.editorial = editorial;
			this.area = area;
			this.id = id;
		}

		public String Codigo { get { return this.codigo; } set { this.codigo = value; } }
		public String Nombre { get { return this.nombre; } set { this.nombre = value; } }
		public int NumeroPaginas { get { return this.numeroPaginas; } set { this.numeroPaginas = value; } }
		public String Autor { get { return this.autor; } set { this.autor = value; } }
		public String Editorial { get { return this.editorial; } set { this.editorial = value; } }
		public String Area { get { return this.area; } set { this.area = value; } }
		public int Id { get { return this.id; } set { this.id = value; } }
	}
}
