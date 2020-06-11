using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca
{
	public partial class Users : System.Web.UI.Page
	{
		private Bussiness.ControlUsuarios users;
		
		protected void Page_Load(object sender, EventArgs e)
		{
			users = new Bussiness.ControlUsuarios();

	
		}
		
		public void agregarUser(object sender, EventArgs e)
		{
			if (IsValid)
			{
				registro();
			}

			
		}

		public void registro()
		{

			String documento = this.addUserDocumento.Text;
			String nombre = this.addUserNombre.Text;
			String dirreccion = this.addUserDireccion.Text;
			String telefono = this.addUserTelefono.Text;
			String correo = this.addUserCorreo.Text;

			if (users.RegistrarUsuario(new Entities.Usuario(documento, nombre, dirreccion, telefono, correo)))
			{
				this.mensajeAddUser.Visible = true;
				this.mensajeAddUser.CssClass = "alert alert-success";
				this.mensajeAddUser.Text = "Registrado";
				clear();
				Response.Redirect("UserLista.aspx");
				
			}
			else
			{
				this.mensajeAddUser.Visible = true;
				this.mensajeAddUser.CssClass = "alert alert-danger";
				this.mensajeAddUser.Text = "Error";
				
			}
		}

		

		public void clear()
		{
			this.addUserDocumento.Text = null;
			this.addUserNombre.Text = null;
			this.addUserDireccion.Text = null;
			this.addUserTelefono.Text = null;
			this.addUserCorreo.Text = null;
		}


	}
}