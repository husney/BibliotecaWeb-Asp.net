using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca.Vistas
{
	public partial class Prestamos : System.Web.UI.Page
	{

		private	Bussiness.ControlPrestamos prestamo;

		protected void Page_Load(object sender, EventArgs e)
		{
			this.prestamo = new Bussiness.ControlPrestamos();
		}


		public void Agregar(object sender, EventArgs e)
		{
			if (IsValid)
			{
				String usuario = this.usuario.Text;
				String libro = this.libro.Text;
				String fInicio = this.fechaInicio.Text;
				String fFin = this.fechaFin.Text;
				int sancion = Convert.ToInt32(this.diasSancion.Text);
				int cantidad = Convert.ToInt32(this.cantidad.Text);

				if(prestamo.AgregarPrestamo(new Entities.DetallePrestamos(usuario, libro, fInicio, fFin, sancion, cantidad)))
				{
					msgPrestamo.Visible = true;
					msgPrestamo.CssClass = "alert alert-success";
					msgPrestamo.Text = "Registrado";
					Response.Redirect("PrestamosLista.aspx");
				}
				else
				{
					msgPrestamo.Visible = true;
					msgPrestamo.CssClass = "alert alert-danger";
					msgPrestamo.Text = "Error";
				}
			}
		}
	}
}