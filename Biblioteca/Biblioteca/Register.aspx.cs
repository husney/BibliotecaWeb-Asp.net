using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Biblioteca
{
	public partial class Register : System.Web.UI.Page
	{
		Bussiness.BussinesLoginReg log;

		protected void Page_Load(object sender, EventArgs e)
		{
			log = new Bussiness.BussinesLoginReg();

			if (IsPostBack)
			{
				
	
			}
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			if (this.terminos.Checked)
			{
				if (this.regUser.Text != "" )
				{
					if(this.regPass.Text != "")
					{
						if (log.RegistroCuenta(new Entities.Sesion(this.regUser.Text, this.regPass.Text)))
						{
							msg.Text = "Registrado";
						}
						else
						{
							msg.Text = "Error al registrar";
						}
					}
					else
					{
						//Response.Write("<script> alert('Ingrese una contraseña'); </script>");
					}
				}
				else
				{
					//Response.Write("<script> alert('Ingrese un usuario'); </script>");
				}
			}
			else
			{

				//Response.Write("<script> alert('Acepte Terminos'); </script>");
			}


		}
	}
}