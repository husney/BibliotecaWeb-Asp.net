using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca.Vistas
{
	public partial class UserEliminar : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Bussiness.ControlUsuarios user = new Bussiness.ControlUsuarios();
			Entities.Usuario usuario = new Entities.Usuario();
			usuario.Documento = Request.QueryString["documento"];
			user.eliminar(usuario);
			Response.Redirect("UserLista.aspx");
		}
	}
}