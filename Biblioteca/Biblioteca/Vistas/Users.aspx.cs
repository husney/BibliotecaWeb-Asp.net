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
		protected void Page_Load(object sender, EventArgs e)
		{

		}
		

		public void agregarUser(object sender, EventArgs e)
		{
			if (IsValid)
			{
				this.mensajeAddUser.Text = "Registrado";
			}
		}

	}
}