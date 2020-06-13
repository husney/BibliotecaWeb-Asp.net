using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bussiness
{

	public class ControlPrestamos
	{
		private DataAccess.DB con;

		public ControlPrestamos()
		{
			con = new DataAccess.DB();
		}

		//AGREGAR
		public bool AgregarPrestamo(Entities.DetallePrestamos prestamo)
		{
			SqlConnection c = null;
			SqlCommand comandAgregar = null;

			String sql = "INSERT INTO detallePrestamos (preUsuario, preLibro, preFechaInicio, preFechaFin, preDiasSancion, preCantidad) VALUES (@usuario, @libro, @inicio, @fin, @sancion, @cantidad)";

			try
			{
				c = con.getConexion();
				comandAgregar = new SqlCommand(sql, c);
				comandAgregar.Parameters.AddWithValue("@usuario", prestamo.Usuario);
				comandAgregar.Parameters.AddWithValue("@libro", prestamo.Libro);
				comandAgregar.Parameters.AddWithValue("@inicio", prestamo.FechaInicio);
				comandAgregar.Parameters.AddWithValue("@fin", prestamo.FechaFin);
				comandAgregar.Parameters.AddWithValue("@sancion", prestamo.DiasSancion);
				comandAgregar.Parameters.AddWithValue("@cantidad", prestamo.Cantidad);
				comandAgregar.ExecuteNonQuery();
				return true;
			}catch(Exception ex)
			{
				ex.ToString();
				return false;
			}
			finally
			{
				c.Close();
				comandAgregar = null;
			}
		}

		//LISTAR
		public List<Entities.DetallePrestamos> prestamos()
		{
			List<Entities.DetallePrestamos> datos = new  List<Entities.DetallePrestamos>();
			SqlConnection c = null;
			SqlCommand comandLista = null;
			SqlDataReader data = null;

			String sql = "SELECT preCodigo, preUsuario, preLibro, preFechaInicio, preFechaFin, preDiasSancion, preCantidad FROM detallePrestamos";

			try
			{
				c = con.getConexion();
				comandLista = new SqlCommand(sql, c);
				data = comandLista.ExecuteReader();
				while (data.Read())
				{
					int codigo = Convert.ToInt32(data["preCodigo"].ToString());
					String usuario = data["preUsuario"].ToString();
					String libro = data["preLibro"].ToString();
					String inicio = data["preFechaInicio"].ToString();
					String fin = data["preFechaFin"].ToString();
					int sancion = Convert.ToInt32(data["preDiasSancion"].ToString());
					int cantidad = Convert.ToInt32(data["preCantidad"].ToString());

					datos.Add(new Entities.DetallePrestamos(codigo, usuario, libro, inicio, fin, sancion, cantidad));
				}

				return datos;
			}catch(Exception ex)
			{
				ex.ToString();
				return null;
			}
		}

		//ELIMINAR
		public void eliminarPrestamo(String codigo)
		{
			SqlConnection c = null;
			SqlCommand comandEliminar = null;

			String sql = "DELETE detallePrestamos WHERE preCodigo = @codigo";

			try
			{
				c = con.getConexion();
				comandEliminar = new SqlCommand(sql, c);
				comandEliminar.Parameters.AddWithValue("@codigo", codigo);
				comandEliminar.ExecuteNonQuery();
			}catch(Exception ex)
			{
				ex.ToString();
			}
			finally
			{
				c.Close();
				comandEliminar = null;
			}
		}

		//BUSCAR PRESTAMO
		public List<Entities.DetallePrestamos> buscarPrestamo(String codigo)
		{
			List<Entities.DetallePrestamos> prestamo = new List<Entities.DetallePrestamos>();
			SqlConnection c = null;
			SqlCommand comandPrestamo = null;
			SqlDataReader datos = null;

			String sql = "SELECT preUsuario, preLibro, preFechaInicio, preFechaFin, preDiasSancion, preCantidad FROM detallePrestamos WHERE preCodigo = @codigo";

			try
			{
				c = con.getConexion();
				comandPrestamo = new SqlCommand(sql, c);
				comandPrestamo.Parameters.AddWithValue("@codigo", codigo);
				datos = comandPrestamo.ExecuteReader();
				if (datos.Read())
				{
					String usuario = datos["preUsuario"].ToString();
					String libro = datos["preLibro"].ToString();
					String fInicio = Convert.ToDateTime(datos["preFechaInicio"].ToString()).ToString("yyyy-MM-dd");
					String fFin = Convert.ToDateTime(datos["preFechaFin"].ToString()).ToString("yyyy-MM-dd");
					int sancion = Convert.ToInt32(datos["preDiasSancion"].ToString());
					int cantidad = Convert.ToInt32(datos["preCantidad"].ToString());

					prestamo.Add(new Entities.DetallePrestamos(usuario, libro, fInicio, fFin, sancion, cantidad));
				}
				return prestamo;
			}catch(Exception ex)
			{
				ex.ToString();
				return null;
			}
			finally
			{
				c.Close();
				datos.Close();
				comandPrestamo = null;
			}
		}

		//ACTUALIZAR
		public bool ActualizarPrestamo(Entities.DetallePrestamos prestamo, String cod)
		{
			SqlConnection c = null;
			SqlCommand commandActualizar = null;

			String sql = "UPDATE detallePrestamos SET preUsuario = @usuario, preLibro = @libro, preFechaInicio = @fInicio, preFechaFin = @fFin, preDiasSancion = @dias, preCantidad = @cantidad  WHERE preCodigo = @cod";

			try
			{
				c = con.getConexion();
				commandActualizar = new SqlCommand(sql, c);
				commandActualizar.Parameters.AddWithValue("@usuario", prestamo.Usuario);
				commandActualizar.Parameters.AddWithValue("@libro", prestamo.Libro);
				commandActualizar.Parameters.AddWithValue("@fInicio", prestamo.FechaInicio);
				commandActualizar.Parameters.AddWithValue("@fFin", prestamo.FechaFin);
				commandActualizar.Parameters.AddWithValue("@dias", prestamo.DiasSancion);
				commandActualizar.Parameters.AddWithValue("@cantidad", prestamo.Cantidad);
				commandActualizar.Parameters.AddWithValue("@cod", cod);
				commandActualizar.ExecuteNonQuery();
				return true;
			}catch(Exception ex)
			{
				ex.ToString();
				return false;
			}
			finally
			{
				c.Close();
				commandActualizar = null;
			}
		}
	}
}
