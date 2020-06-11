using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca.Vistas
{
	public partial class AreasActualizar : System.Web.UI.Page
	{
		private Bussiness.ControlAreas areas;
		private List<Entities.Area> area = new List<Entities.Area>();
		private String codigo;
		private String nombre;
		private String cod;

		protected void Page_Load(object sender, EventArgs e)
		{
			areas = new Bussiness.ControlAreas();
			cod = Request.QueryString["codigo"];
			area = areas.buscarRegistro(cod);
			foreach(Entities.Area a in area)
			{
				this.Codigo = a.Codigo;
				this.Nombre = a.Nombre;
			}

		}

		public void Actualizar(object sender, EventArgs e)
		{
			if (IsValid)
			{
				String codigo = this.actualizarCod.Text;
				String nomb = this.actualizarNomb.Text;

				if (areas.Actualizar(new Entities.Area(codigo, nomb), cod))
				{
					Response.Redirect("AreasLista.aspx");
				}
				else
				{
					this.msgActualizar.Visible = true;
					this.msgActualizar.CssClass = "alert alert-danger";
					this.msgActualizar.Text = "Error";
				}
			}
		}

		public String Codigo { get => codigo; set => this.codigo = value; }
		public string Nombre { get => nombre; set => nombre = value; }


	}		
}