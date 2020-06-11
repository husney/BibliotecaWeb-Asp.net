using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Biblioteca.Vistas
{
	public partial class UserLista : System.Web.UI.Page
	{
		private Bussiness.ControlUsuarios users;
		public SqlDataReader read;
		public List<Entities.Usuario> usuarios = new List<Entities.Usuario>();
		

		protected void Page_Load(object sender, EventArgs e)
		{
			this.users = new Bussiness.ControlUsuarios();
			

			if (IsPostBack)
			{
				this.usuarios = users.Listar();
			}

			this.usuarios = users.Listar();

		}

		public SqlDataReader listar()
		{
			return this.read;
		}

		//public List<Entities.Usuario> getLista()
		//{
		//	return this.usuarios;
		//}




	}
}