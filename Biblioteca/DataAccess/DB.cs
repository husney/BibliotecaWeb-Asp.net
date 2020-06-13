using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
	public class DB
	{
		SqlConnection conexion = new SqlConnection("server=HUSNEY; database=BIBLIOTECA; integrated security=true;");

		public SqlConnection getConexion()
		{
			try
			{
				Console.WriteLine("Conectandoce...");

				if(conexion.State.ToString() == "Open")
				{
					return conexion;
				}
				else
				{
					conexion.Open();
					Console.WriteLine("Conectado");
					return conexion;
				}
			}catch (Exception ex)
			{
				Console.WriteLine("Error en la Conexion");
				ex.ToString();
				return null;
			}
		}
		
	}
}


