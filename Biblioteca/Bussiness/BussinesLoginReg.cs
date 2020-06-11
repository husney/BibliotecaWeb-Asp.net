using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bussiness
{
    public class BussinesLoginReg
    {
		DataAccess.DB con;

		public BussinesLoginReg()
		{
			con = new DataAccess.DB();

		}

		public bool RegistroCuenta(Entities.Sesion user)
		{
			SqlConnection c = null;
			
			String sql = "INSERT INTO sesion (usuario, contraseña) VALUES (@usuario, @contraseña)";

			try
			{
				c = con.getConexion();
				SqlCommand comando = new SqlCommand(sql, c);
				comando.Parameters.AddWithValue("@usuario", user.Usuario);
				comando.Parameters.AddWithValue("@contraseña", user.Contraseña);
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
			}
		}

		public bool IniciarSesion(Entities.Sesion user)
		{
			SqlConnection c = null;
			String sql = "SELECT cuenta, usuario, contraseña FROM sesion WHERE usuario = @usuario AND contraseña = @contraseña";

			try
			{
				c = con.getConexion();
				SqlCommand comando = new SqlCommand(sql, c);
				comando.Parameters.AddWithValue("@usuario", user.Usuario);
				comando.Parameters.AddWithValue("contraseña", user.Contraseña);
				SqlDataReader lector = comando.ExecuteReader();

				if (lector.Read())
				{
					String usuario = lector["usuario"].ToString();
					String contraseña = lector["contraseña"].ToString();
					
					if (usuario.Equals(user.Usuario) && contraseña.Equals(user.Contraseña))
					{
						return true;
					}
					else
					{
						return false;
					}

				}
				else
				{
					return false;
				}

			}
			catch (Exception ex)
			{
				return false;
			}
			finally
			{
				c.Close();
			}
			
		}
    }
}
