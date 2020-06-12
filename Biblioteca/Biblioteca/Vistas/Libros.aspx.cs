using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca.Vistas
{
	public partial class Libros : System.Web.UI.Page
	{
		private Bussiness.ControlLibros libros;
		String a;

		protected void Page_Load(object sender, EventArgs e)
		{
			this.libros = new Bussiness.ControlLibros();

			if (!IsPostBack)
			{
				this.addArea.DataSource = libros.MostrarAreas();
				this.addArea.DataBind();
			}
			a = libros.CodigoArea(this.addArea.SelectedItem.ToString());
			
		}

		public void Agregar(object sender, EventArgs e)
		{
			if (IsValid)
			{
				String caracteres = this.addCodigo.Text;	

				if(caracteres.Length <= 10)
				{
					
					String codigo = this.addCodigo.Text;
					String nombre = this.addNombre.Text;
					int numPaginas = Convert.ToInt32(this.addNumPag.Text);
					String autor = this.addAutor.Text;
					String editorial = this.addEditorial.Text;
					



					if (libros.Agregar(new Entities.Libro(codigo, nombre, numPaginas, autor, editorial, a)))
					{
						this.msgAddLibro.Visible = true;
						this.msgAddLibro.CssClass = "alert alert-success";
						this.msgAddLibro.Text = "Registrado";
						Response.Redirect("LibrosLista.aspx");
					}
					else
					{
						this.msgAddLibro.Visible = true;
						this.msgAddLibro.CssClass = "alert alert-danger";
						this.msgAddLibro.Text = "Error";
					}
				}
				else
				{
					this.msgAddLibro.Visible = true;
					this.msgAddLibro.CssClass = "alert alert-danger";
					this.msgAddLibro.Text = "El codigo solo puede tener un maximo de 10 caracteres";
				}

			}
		}
	}
}