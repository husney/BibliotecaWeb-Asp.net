using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bussiness
{
	public class ControlAreas
	{
		private DataAccess.DB con;

		public ControlAreas()
		{
			this.con = new DataAccess.DB();
		}

		//<!--areCodigo areNombre areTiempo areId-->

		//REGISTRAR
		public bool RegistrarArea(Entities.Area area)
		{
			SqlConnection c = null;
			SqlCommand comand = null;

			String query = "INSERT INTO areas (areCodigo, areNombre, areTiempo) VALUES (@codigo, @nombre, GETDATE())";

			try
			{
				c = con.getConexion();
				comand = new SqlCommand(query, c);
				comand.Parameters.AddWithValue("@codigo", area.Codigo);
				comand.Parameters.AddWithValue("@nombre", area.Nombre);
				comand.ExecuteNonQuery();
				return true;
			}catch (Exception ex)
			{
				ex.ToString();
				return false;
			}
			finally
			{
				c.Close();
				comand = null;
			}
		}

		//LISTAR
		public List<Entities.Area> listarAreas()
		{
			List<Entities.Area> areas = new List<Entities.Area>();
			SqlConnection c = null;
			SqlCommand comand ;
			SqlDataReader reader;

			String query = "SELECT areCodigo, areNombre, areTiempo, areId FROM areas";

			try
			{
				c = con.getConexion();
				comand = new SqlCommand(query, c);
				reader = comand.ExecuteReader();
				while (reader.Read())
				{
					String codigo = reader["areCodigo"].ToString();
					String nombre = reader["areNombre"].ToString();
					String tiempo = reader["areTiempo"].ToString();
					int id = Convert.ToInt32(reader["areId"].ToString());
					areas.Add(new Entities.Area(codigo, nombre, tiempo, id));
				}
				return areas;
			}catch(Exception ex)
			{
				ex.ToString();
				return null;
			}
			finally
			{
				c.Close();
				comand = null;
				reader = null;
			}

		}

		//ELIMINAR
		public void eliminar (String codigo)
		{
			SqlConnection c;
			SqlCommand comand;

			String query = "DELETE areas WHERE areCodigo = @codigo";

			try
			{
				c = con.getConexion();
				comand = new SqlCommand(query, c);
				comand.Parameters.AddWithValue("@codigo", codigo);
				comand.ExecuteNonQuery();
			}catch (Exception ex)
			{
				ex.ToString();
			}
		}


		//BUSCAR REGISTRO
		public List<Entities.Area> buscarRegistro(String codigo)
		{
			List<Entities.Area> registro = new List<Entities.Area>();
			SqlConnection c;
			SqlCommand comando;
			SqlDataReader reg = null ;

			String query = "SELECT areCodigo, areNombre FROM areas WHERE areCodigo = @codigo";

			try
			{
				c = con.getConexion();
				comando = new SqlCommand(query, c);
				comando.Parameters.AddWithValue("@codigo", codigo);
				reg = comando.ExecuteReader();
				if (reg.Read())
				{
					String cod = reg["areCodigo"].ToString();
					String nomb = reg["areNombre"].ToString();
					registro.Add(new Entities.Area(cod, nomb));
				}
				return registro;
			}catch(Exception ex)
			{
				ex.ToString();
				return null;
			}
			finally
			{
				reg.Close();
			}
			
		}

		//Actualizar
		public bool Actualizar(Entities.Area area, String codigo)
		{
			SqlConnection c;
			SqlCommand comandActualizar;

			String sql = "UPDATE areas SET areCodigo = @codigo,  areNombre = @nombre WHERE areCodigo = @codigoUp";

			try
			{
				c = con.getConexion();
				comandActualizar = new SqlCommand(sql, c);
				comandActualizar.Parameters.AddWithValue("@codigo", area.Codigo);
				comandActualizar.Parameters.AddWithValue("@nombre", area.Nombre);
				comandActualizar.Parameters.AddWithValue("@codigoUp", codigo);
				comandActualizar.ExecuteNonQuery();
				return true;
			}catch(Exception ex)
			{
				ex.ToString();
				return false;
			}
			
		}

	}
}
