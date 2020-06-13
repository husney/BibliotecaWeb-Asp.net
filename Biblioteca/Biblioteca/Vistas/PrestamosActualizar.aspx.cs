using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca.Vistas
{
	public partial class PrestamosActualizar : System.Web.UI.Page
	{
		private Bussiness.ControlPrestamos prestamo;
		private List<Entities.DetallePrestamos> datos = new List<Entities.DetallePrestamos>();
		private String usuario;
		private String libro;
		private String fInicio;
		private String fFinal;
		private int dSancion;
		private int cantidad;
		private String cod;


		protected void Page_Load(object sender, EventArgs e)
		{
			this.prestamo = new Bussiness.ControlPrestamos();

			 cod = Request.QueryString["codigo"];
			this.datos = prestamo.buscarPrestamo(cod);

			foreach(Entities.DetallePrestamos det in datos)
			{
				this.Usuario = det.Usuario;
				this.Libro = det.Libro;
				this.FInicio = det.FechaInicio;
				this.FFinal = det.FechaFin;
				this.DSancion = det.DiasSancion;
				this.Cantidad = det.Cantidad;
			}


		}

		public void Actualizar(object sender, EventArgs e)
		{
			if (IsValid)
			{
				String user = this.actUsuario.Text;
				String libro = this.actLibro.Text;
				String fecIn = this.actFechaInicio.Text;
				String fecFn = this.actFechaFin.Text;
				int dur = Convert.ToInt32(this.actDiasSancion.Text);
				int cant = Convert.ToInt32(this.actCantidad.Text);

				if (prestamo.ActualizarPrestamo(new Entities.DetallePrestamos(user, libro, fecIn, fecFn, dur, cant),cod))
				{
					Response.Redirect("PrestamosLista.aspx");
				}
				else
				{
					this.msgPrestamo.Visible = true;
					this.msgPrestamo.CssClass = "text-center alert alert-danger";
					this.msgPrestamo.Text = "Error";
				}


			}
		}

		public string Usuario { get => usuario; set => usuario = value; }
		public string Libro { get => libro; set => libro = value; }
		public string FInicio { get => fInicio; set => fInicio = value; }
		public string FFinal { get => fFinal; set => fFinal = value; }
		public int DSancion { get => dSancion; set => dSancion = value; }
		public int Cantidad { get => cantidad; set => cantidad = value; }

	}
}