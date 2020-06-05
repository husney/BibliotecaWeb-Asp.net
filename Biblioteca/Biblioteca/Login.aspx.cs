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
		protected void Page_Load(object sender, EventArgs e)
		{

		}
		protected void Button1_Click1(object sender, EventArgs e)
		{
			String user = this.TextBox1.Text;
			String pass = this.TextBox2.Text;
			Response.Write(user + pass + "hola");
		}

		
	}
}