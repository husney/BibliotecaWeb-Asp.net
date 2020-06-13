using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca.Vistas
{
	public partial class PrestamosEliminar : System.Web.UI.Page
	{
		Bussiness.ControlPrestamos prestamo;

		protected void Page_Load(object sender, EventArgs e)
		{
			this.prestamo = new Bussiness.ControlPrestamos();
			String cod = Request.QueryString["codigo"];
			prestamo.eliminarPrestamo(cod);
			Response.Redirect("PrestamosLista.aspx");
		}
	}
}