using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca.Vistas
{
	public partial class Areas : System.Web.UI.Page
	{
		private Bussiness.ControlAreas area;

		protected void Page_Load(object sender, EventArgs e)
		{
			area = new Bussiness.ControlAreas();
		}

		public void registrar(object sender, EventArgs e)
		{
			if (IsValid)
			{
				String codigo = this.addAreasCodigo.Text;
				String nombre = this.addAreasNombre.Text;

				if(area.RegistrarArea(new Entities.Area(codigo, nombre)))
				{
					this.msgAddLibro.Visible = true;
					this.msgAddLibro.CssClass = "alert alert-success";
					this.msgAddLibro.Text = "Registrado";
					Response.Redirect("AreasLista.aspx");
				}
				else
				{
					this.msgAddLibro.Visible = true;
					this.msgAddLibro.CssClass = "alert alert-danger";
					this.msgAddLibro.Text = "Error";
				}
			}

		}
	}
}