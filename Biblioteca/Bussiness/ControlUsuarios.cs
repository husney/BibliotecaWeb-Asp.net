using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bussiness
{
	public class ControlUsuarios
	{
		private DataAccess.DB con;

		public ControlUsuarios()
		{
			con = new DataAccess.DB();
		}


		//usuDocumento usuNombre usuDireccion usuTelefono usuCorreo usuEstado usuId
		public bool RegistrarUsuario(Entities.Usuario user)
		{
			SqlConnection c = con.getConexion();
			String sql = "INSERT INTO usuarios (usuDocumento, usuNombre, usuDireccion, usuTelefono, usuCorreo, usuEstado) VALUES (@documento, @nombre, @direccion, @telefono, @correo, @estado)";

			try
			{
				SqlCommand comand = new SqlCommand(sql, c);
				comand.Parameters.AddWithValue("@documento", user.Documento);
				comand.Parameters.AddWithValue("@nombre", user.Nombre);
				comand.Parameters.AddWithValue("@direccion", user.Direccion);
				comand.Parameters.AddWithValue("@telefono", user.Telefono);
				comand.Parameters.AddWithValue("@correo", user.Correo);
				comand.Parameters.AddWithValue("estado", "Libre");
				comand.ExecuteNonQuery();
				return true;
			}catch(Exception ex)
			{
				ex.ToString();
				return false;
			}
			finally
			{
				c.Close();
			}

		}



		public List<Entities.Usuario> Listar()
		{
			List<Entities.Usuario> usuarios = new List<Entities.Usuario>();
			SqlConnection c = con.getConexion();
			String query = "SELECT usuDocumento, usuNombre, usuDireccion, usuTelefono, usuCorreo, usuEstado, usuId FROM usuarios";
			SqlDataReader lector = null;
			try
			{
				SqlCommand comand = new SqlCommand(query, c);
				 lector = comand.ExecuteReader();
				while (lector.Read())
				{
					String documento = lector["usuDocumento"].ToString();
					String nombre = lector["usuNombre"].ToString();
					String direccion = lector["usuDireccion"].ToString();
					String telefono = lector["usuTelefono"].ToString();
					String correo = lector["usuCorreo"].ToString();
					String estado = lector["usuEstado"].ToString();
					int id = Convert.ToInt32(lector["usuId"].ToString());
					usuarios.Add(new Entities.Usuario(documento, nombre, direccion, telefono, correo, estado, id));
				}

				return usuarios;

			}catch(Exception ex)
			{
				return null;
			}
			finally
			{
				lector.Close();
			}
		}

		public List<Entities.Usuario> ActualizarUsuario(String doc)
		{
			List<Entities.Usuario> usuario = new List<Entities.Usuario>();
			SqlConnection c = con.getConexion();
			SqlCommand comand = null;
			SqlDataReader read = null;

			String query = "SELECT usuDocumento, usuNombre, usuDireccion, usuTelefono, usuCorreo, usuEstado, usuId FROM usuarios WHERE  usuDocumento = @doc";

			try
			{
				comand = new SqlCommand(query, c);
				comand.Parameters.AddWithValue("@doc", doc);
				read = comand.ExecuteReader();

				if (read.Read())
				{
					String documento = read["usuDocumento"].ToString();
					String nombre = read["usuNombre"].ToString();
					String direccion = read["usuDireccion"].ToString();
					String telefono = read["usuTelefono"].ToString();
					String correo = read["usuCorreo"].ToString();
					String estado = read["usuEstado"].ToString();
					int id = Convert.ToInt32(read["usuId"].ToString());
					usuario.Add(new Entities.Usuario(documento, nombre, direccion, telefono, correo, estado, id));
					
				}
				return usuario;
			}catch(Exception ex)
			{
				ex.ToString();
				return null;
			}
			finally
			{
				read.Close();
			}
		}

		public bool Actualización(Entities.Usuario user, String doc)
		{
			SqlConnection c = null;
			SqlCommand comando = null;
			//SqlDataReader lector = null;

			String query = "UPDATE usuarios SET usuDocumento = @documento, usuNombre = @nombre, usuDireccion = @direccion, usuTelefono = @telefono, usuCorreo = @correo, usuEstado = @estado WHERE usuDocumento = @documentoUP";

			try
			{
				c = con.getConexion();
				comando = new SqlCommand(query, c);
				comando.Parameters.AddWithValue("@documento", user.Documento);
				comando.Parameters.AddWithValue("@nombre", user.Nombre);
				comando.Parameters.AddWithValue("@direccion", user.Direccion);
				comando.Parameters.AddWithValue("@telefono", user.Telefono);
				comando.Parameters.AddWithValue("@correo", user.Correo);
				comando.Parameters.AddWithValue("@estado", user.Estado);
				comando.Parameters.AddWithValue("@documentoUP", doc);
				comando.ExecuteNonQuery();
				return true;
			}catch (Exception ex)
			{
				ex.ToString();
				return false;
			}
			finally
			{
				c.Close();
				comando = null;
			}
		}

		public void eliminar(Entities.Usuario user)
		{
			SqlConnection c = con.getConexion();
			String sql = "DELETE FROM usuarios WHERE usuDocumento = @documento";
			
			try {
				SqlCommand comand = new SqlCommand(sql, c);
				comand.Parameters.AddWithValue("@documento", user.Documento);
				comand.ExecuteNonQuery();
			} catch(Exception ex)
			{

			}
			finally
			{
				c.Close();
			}

		}







	}
}
