using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca
{
	public partial class Biblioteca : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

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
	}
}