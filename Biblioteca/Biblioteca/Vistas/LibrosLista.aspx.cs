using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca.Vistas
{
	public partial class LibrosLista : System.Web.UI.Page
	{
		public Bussiness.ControlLibros libros;
		public List<Entities.Libro> datos = new List<Entities.Libro>();

		protected void Page_Load(object sender, EventArgs e)
		{
			this.libros = new Bussiness.ControlLibros();
			this.datos = libros.libros();
			
		}

		
		
	}
}