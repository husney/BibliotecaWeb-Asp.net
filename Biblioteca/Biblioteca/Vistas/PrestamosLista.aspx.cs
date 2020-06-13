using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca.Vistas
{
	public partial class PrestamosLista : System.Web.UI.Page
	{
		private Bussiness.ControlPrestamos prestamos;
		public List<Entities.DetallePrestamos> datos = new List<Entities.DetallePrestamos>();

		protected void Page_Load(object sender, EventArgs e)
		{
			prestamos = new Bussiness.ControlPrestamos();
			this.datos = prestamos.prestamos();

		}
	}
}