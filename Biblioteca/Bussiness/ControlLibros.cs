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

		//Listar Areas
		public List<Entities.Area> MostrarAreas()
		{
			List<Entities.Area> areas = new List<Entities.Area>();
			SqlConnection c = null;
			SqlCommand comandAreas;
			SqlDataReader datos = null;

			String query = "SELECT areCodigo, areNombre FROM areas";
			try {
				c = con.getConexion();
				comandAreas = new SqlCommand(query, c);
				datos = comandAreas.ExecuteReader();
				while (datos.Read())
				{
					//String codigo = datos.GetValue(0).ToString();
					String nombre = datos.GetValue(1).ToString();
					areas.Add(new Entities.Area(nombre));
				}
				return areas;
			} catch (Exception ex)
			{
				ex.ToString();
				return null;
			}
			finally
			{
				datos.Close();
			}
		}

		//CodigoArea
		public String CodigoArea(String nombre)
		{
			SqlConnection c = null;
			SqlCommand comandCodigo;
			SqlDataReader codigo = null;

			String sql = "SELECT areCodigo FROM areas WHERE areNombre = @nombre";

			try
			{
				c = con.getConexion();
				comandCodigo = new SqlCommand(sql, c);
				comandCodigo.Parameters.AddWithValue("@nombre", nombre);
				codigo = comandCodigo.ExecuteReader();
				if (codigo.Read())
				{
					return codigo.GetValue(0).ToString();
				}
				else
				{
					return null;
				}
			}catch(Exception ex)
			{
				ex.ToString();
				return null;
			}
			finally
			{
				c.Close();
				codigo.Close();
			}
		}

		//Agregar
		public bool Agregar(Entities.Libro libro)
		{
			SqlConnection c;
			SqlCommand comandAgregar;
			
			String sql = "INSERT INTO libros (libCodigo, libNombre, libNumPag, libAutor, libEditorial, libArea) VALUES (@codigo, @nombre ,@paginas, @autor, @editorial, @area)";

			try
			{
				c = con.getConexion();
				comandAgregar = new SqlCommand(sql, c);
				comandAgregar.Parameters.AddWithValue("@codigo", libro.Codigo);
				comandAgregar.Parameters.AddWithValue("@nombre", libro.Nombre);
				comandAgregar.Parameters.AddWithValue("@paginas", libro.NumeroPaginas);
				comandAgregar.Parameters.AddWithValue("@autor", libro.Autor);
				comandAgregar.Parameters.AddWithValue("@editorial", libro.Editorial);
				comandAgregar.Parameters.AddWithValue("@area", libro.Area);
				comandAgregar.ExecuteNonQuery();
				return true;
			}catch(Exception ex)
			{
				ex.ToString();
				return false;
			}
			
		}

		//LISTAR LIBROS
		public List<Entities.Libro> libros()
		{
			List<Entities.Libro> libros = new List<Entities.Libro>();
			SqlConnection c = null;
			SqlCommand comandLibros = null;
			SqlDataReader datosLibros = null;
			
			String sql = "SELECT libCodigo, libNombre, libNumPag, libAutor, libEditorial, libArea, libId FROM libros";

			try
			{
				c = con.getConexion();
				comandLibros = new SqlCommand(sql, c);
				datosLibros = comandLibros.ExecuteReader();
				while (datosLibros.Read())
				{
					String codigo = datosLibros["libCodigo"].ToString();
					String nombre = datosLibros["libNombre"].ToString();
					int numPag = Convert.ToInt32(datosLibros["libNumPag"].ToString());
					String autor = datosLibros["libAutor"].ToString();
					String editorial = datosLibros["libEditorial"].ToString();
					String area = datosLibros["libArea"].ToString();
					int id = Convert.ToInt32(datosLibros["libId"].ToString());

					libros.Add(new Entities.Libro(codigo, nombre, numPag, autor, editorial, area, id));
				}
				return libros;

			}catch(Exception ex)
			{
				ex.ToString();
				return null;
			}
			finally
			{
				c.Close();
				datosLibros.Close();
				comandLibros = null;
			}
		}
		

	
		//ELIMINAR
		public void Eliminar(String codigo)
		{
			SqlConnection c = null;
			SqlCommand comandEliminar = null;

			String sql = "DELETE libros WHERE libCodigo = @codigo";

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

		//LIBRO A ACTUALIZAR
		public List<Entities.Libro> libro(String codigo)
		{
			List<Entities.Libro> datos = new List<Entities.Libro>();
			SqlConnection c = null;
			SqlCommand comandoLibro = null;
			SqlDataReader informacion = null;

			String sql = "SELECT libCodigo, libNombre, libNumPag, libAutor, libEditorial, libArea, libId FROM libros WHERE libCodigo = @codigo";

			try
			{
				c = con.getConexion();
				comandoLibro = new SqlCommand(sql, c);
				comandoLibro.Parameters.AddWithValue("@codigo", codigo);
				informacion = comandoLibro.ExecuteReader();
				if (informacion.Read())
				{
					String cod = informacion["libCodigo"].ToString();
					String nom = informacion["libNombre"].ToString();
					int pag = Convert.ToInt32(informacion["libNumPag"].ToString());
					String autor = informacion["libAutor"].ToString();
					String editorial = informacion["libEditorial"].ToString();
					String area = informacion["libArea"].ToString();
					int id = Convert.ToInt32(informacion["libId"].ToString());

					datos.Add(new Entities.Libro(cod, nom, pag, autor, editorial, area, id));
				}
				return datos;
			}catch(Exception ex)
			{
				ex.ToString();
				return null;
			}
			finally
			{
				c.Close();
				informacion.Close();
				comandoLibro = null;
			}
		}

		//ACTUALIZAR
		public bool Actualizar(Entities.Libro libro, String cod)
		{
			SqlConnection c = null;
			SqlCommand comandActualizar = null;

			String sql = "UPDATE libros SET libCodigo = @codigo, libNombre = @nombre, libNumPag = @paginas, libAutor = @autor, libEditorial = @editorial, libArea = @area WHERE libCodigo = @codigoUP";

			try
			{
				c = con.getConexion();
				comandActualizar = new SqlCommand(sql, c);
				comandActualizar.Parameters.AddWithValue("@codigo", libro.Codigo);
				comandActualizar.Parameters.AddWithValue("@nombre", libro.Nombre);
				comandActualizar.Parameters.AddWithValue("@paginas", libro.NumeroPaginas);
				comandActualizar.Parameters.AddWithValue("@autor", libro.Autor);
				comandActualizar.Parameters.AddWithValue("@editorial", libro.Editorial);
				comandActualizar.Parameters.AddWithValue("@area", libro.Area);
				comandActualizar.Parameters.AddWithValue("@codigoUp", cod);
				comandActualizar.ExecuteNonQuery();
				return true;
			}catch(Exception ex)
			{
				ex.ToString();
				return false;
			}
			finally
			{
				c.Close();
				comandActualizar = null;
			}
		}
	}
}
