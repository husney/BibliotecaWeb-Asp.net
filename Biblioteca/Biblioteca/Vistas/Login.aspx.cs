using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca
{
	public partial class Login : System.Web.UI.Page 
	{
		private Bussiness.BussinesLoginReg control;
		protected void Page_Load(object sender, EventArgs e)
		{
			control = new Bussiness.BussinesLoginReg();
		}
		protected void Button1_Click1(object sender, EventArgs e)
		{
			if (this.user.Text != "" && this.pass.Text != "")
			{
				if (control.IniciarSesion(new Entities.Sesion(this.user.Text, this.pass.Text)))
				{
					//Ingreso
					this.msg.CssClass = "text-center h4 text-success d-block";
					this.msg.Text = "Correcto";
					Response.Redirect("Biblioteca.aspx");
				}
				else
				{
					//Error
					this.msg.CssClass = "text-center h4 text-danger d-block";
					this.msg.Text = "Error al iniciar sesion";
				}
			}
		}

		
	}
}