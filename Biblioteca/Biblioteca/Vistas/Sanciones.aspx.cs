using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca.Vistas
{
	public partial class Sanciones : System.Web.UI.Page
	{
		private Bussiness.ControlPrestamos sanciones;
		public List<Entities.Sancionados> datos = new List<Entities.Sancionados>();

		protected void Page_Load(object sender, EventArgs e)
		{
			this.sanciones = new Bussiness.ControlPrestamos();

			datos = sanciones.sancionados();
		}
	}
}