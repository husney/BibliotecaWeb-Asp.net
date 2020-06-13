using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca.Vistas
{
	public partial class UserActualizar : System.Web.UI.Page
	{
		private Bussiness.ControlUsuarios user;
		List<Entities.Usuario> usuario;
		private String documento;
		private String nombre;
		private String direccion;
		private String telefono;
		private String correo;
		private String estado;
		private int id;
		private String Updt;

		protected void Page_Load(object sender, EventArgs e)
		{
			user = new Bussiness.ControlUsuarios();
			Updt  = Request.QueryString["documento"];
			usuario = new List<Entities.Usuario>();
			usuario = user.ActualizarUsuario(Updt);
			foreach(Entities.Usuario u in usuario)
			{
				Documento = u.Documento;
				Nombre = u.Nombre;
				Direccion = u.Direccion;
				Telefono = u.Telefono;
				Correo = u.Correo.Trim();
				Estado = u.Estado;
				id = u.Id;
			
			}
		}

		public void Actualizar (object sender, EventArgs e)
		{
			if (IsValid)
			{
				String doc = this.editDocumento.Text;
				String nom = this.editNombre.Text;
				String dir = this.editDireccion.Text;
				String tel = this.editTelefono.Text;
				String cor = this.editCorreo.Text;
				String est = this.editEstados.SelectedItem.Text;

				if (user.Actualización(new Entities.Usuario(doc, nom, dir, tel, cor, est), Updt))
				{
					Response.Redirect("UserLista.aspx");
				}
				else
				{
					this.mensajeAddUser.Visible = true;
					this.mensajeAddUser.CssClass = "alert alert-danger";
					this.mensajeAddUser.Text = "Error al actualizar usuario";
				}
			}


		}

		public String Documento { get => this.documento; set => this.documento = value; }
		public String Nombre { get => this.nombre; set => this.nombre = value; }
		public String Direccion { get => this.direccion; set => this.direccion = value; }
		public String Telefono { get => this.telefono; set => this.telefono = value; }
		public String Correo { get => this.correo; set => this.correo = value; }
		public String Estado { get => this.estado; set => this.estado = value; }
		public int Id { get => this.id; set => this.id = value; }
	}
}