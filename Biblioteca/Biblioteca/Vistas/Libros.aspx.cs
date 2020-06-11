using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca.Vistas
{
	public partial class Libros : System.Web.UI.Page
	{
		private Bussiness.ControlLibros libros;

		protected void Page_Load(object sender, EventArgs e)
		{
			this.libros = new Bussiness.ControlLibros();

			this.addArea.DataSource = libros.MostrarAreas();
			this.addArea.DataBind();
		}
	}
}