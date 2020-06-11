using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca.Vistas
{
	public partial class AreasLista : System.Web.UI.Page
	{
		private Bussiness.ControlAreas areas;

		public List<Entities.Area> lista = new List<Entities.Area>();

		protected void Page_Load(object sender, EventArgs e)
		{
			this.areas = new Bussiness.ControlAreas();

			this.lista = areas.listarAreas();
			
		}


	}
}