using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Area
	{
		private String codigo;
		private String nombre;
		private int tiempo;
		private int id;

		public Area() { }

		public Area(String codigo, String nombre, int tiempo)
		{
			this.codigo = codigo;
			this.nombre = nombre;
			this.tiempo = tiempo;
		}

		public Area(String codigo, String nombre, int tiempo, int id)
		{
			this.codigo = codigo;
			this.nombre = nombre;
			this.tiempo = tiempo;
			this.id = id;
		}

		public String Codigo { get{  return this.codigo; } set { this.codigo = value; } }
		public String Nombre { get { return this.nombre; } set { this.nombre = value; } }
		public int Tiempo { get { return this.tiempo; } set { this.tiempo = value; } }
		public int Id { get { return this.id; } set { this.id = value; } }
    }
}
