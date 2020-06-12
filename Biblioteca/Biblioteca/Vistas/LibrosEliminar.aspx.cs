using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca.Vistas
{
	public partial class LibrosEliminar : System.Web.UI.Page
	{
		private Bussiness.ControlLibros libros;

		protected void Page_Load(object sender, EventArgs e)
		{
			libros = new Bussiness.ControlLibros();
			String codigo = Request.QueryString["codigo"];
			libros.Eliminar(codigo);
			Response.Redirect("LibrosLista.aspx");


		}
	}
}