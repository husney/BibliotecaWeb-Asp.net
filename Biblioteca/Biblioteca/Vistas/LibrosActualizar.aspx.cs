using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca.Vistas
{
	public partial class LibrosActualizar : System.Web.UI.Page
	{
		Bussiness.ControlLibros libros;
		public List<Entities.Libro> datos = new List<Entities.Libro>();
		private String codigo;
		private String nombre;
		private int paginas;
		private String autor;
		private String editorial;
		private String area;
		private int id;
		String cod;

		protected void Page_Load(object sender, EventArgs e)
		{
			libros = new Bussiness.ControlLibros();

			if (!IsPostBack)
			{
				this.actArea.DataSource = libros.MostrarAreas();
				this.actArea.DataBind();
			}

			cod = Request.QueryString["codigo"];

			this.datos = libros.libro(cod);

			foreach(Entities.Libro lib in datos)
			{
				this.Codigo = lib.Codigo;
				this.Nombre = lib.Nombre;
				this.Paginas = lib.NumeroPaginas;
				this.Autor = lib.Autor;
				this.Editorial = lib.Editorial;
			}
		}

		public void Actualizar (object sender, EventArgs e)
		{
			if (IsValid)
			{
				String codig = this.actCodigo.Text;
				String nom = this.actNombre.Text;
				int pag = Convert.ToInt32(this.actNumPag.Text);
				String autr = this.actAutor.Text;
				String edit = this.actEditorial.Text;
				String are = libros.CodigoArea(this.actArea.SelectedItem.ToString());

				if(libros.Actualizar(new Entities.Libro(codig, nom, pag, autr, edit, are), cod))
				{
					Response.Redirect("LibrosLista.aspx");
				}
				else
				{
					msgAddLibro.Visible = true;
					msgAddLibro.CssClass = "alert alert-danger";
					msgAddLibro.Text = "Error";
				}

			}
		}



		
		public String Codigo { get => this.codigo; set => this.codigo = value; }
		public String Nombre { get => this.nombre; set => this.nombre = value; }
		public int Paginas { get => this.paginas; set => this.paginas = value; }
		public String Autor { get => this.autor; set => this.autor = value; }
		public String Editorial { get => this.editorial; set => this.editorial = value; }
		public String Area { get => this.area; set => this.area = value; }
		public int Id { get => this.id; set => this.id = value; }
	}
}