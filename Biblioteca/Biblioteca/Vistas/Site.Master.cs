using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca
{
	public partial class SiteMaster : MasterPage
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			jquery();
		}

		public void jquery()
		{
			ScriptManager.ScriptResourceMapping.AddDefinition(
				"jQuery", new ScriptResourceDefinition
				{
					Path = "~/js/jquery-3.5.1.slim.min.js",
					CdnDebugPath = "~/js/jquery.3.5.1.slim.min.js",
					CdnSupportsSecureConnection = true,
					LoadSuccessExpression = "Window.jQuery"

				}
		   );
		}


		
		public void usuarios(object sender, EventArgs e)
		{
			Response.Redirect("Users.aspx");
		}
	}
}