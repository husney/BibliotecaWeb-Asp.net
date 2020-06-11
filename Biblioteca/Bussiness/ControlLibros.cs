using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bussiness
{
	public class ControlLibros
	{
		private DataAccess.DB con;

		public ControlLibros()
		{
			this.con = new DataAccess.DB();
		}

		public List<Entities.Area> MostrarAreas()
		{
			List<Entities.Area> areas = new List<Entities.Area>();
			SqlConnection c = null;
			SqlCommand comandAreas;
			SqlDataReader datos ;

			String query = "SELECT areCodigo, areNombre FROM areas";
			try{
				comandAreas = new SqlCommand(query, c);
				datos = comandAreas.ExecuteReader();
				while (datos.Read())
				{
					String codigo = datos.GetValue(0).ToString();
					String nombre = datos.GetValue(1).ToString();
					areas.Add(new Entities.Area(codigo, nombre));
				}
				return areas;
			}catch(Exception ex)
			{
				ex.ToString();
				return null;
			}
			finally
			{
				
			}
		}
	}
}
