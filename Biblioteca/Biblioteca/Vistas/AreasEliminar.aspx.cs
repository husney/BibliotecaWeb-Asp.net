using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca.Vistas
{
	public partial class AreasEliminar : System.Web.UI.Page
	{

		Bussiness.ControlAreas area;

		protected void Page_Load(object sender, EventArgs e)
		{
			area = new Bussiness.ControlAreas();
			String codigo = Request.QueryString["codigo"];
			area.eliminar(codigo);
			Response.Redirect("AreasLista.aspx");
		}
	}
}