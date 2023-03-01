using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Datos;
using System.Data.SqlTypes;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
			List<Articulo> lista = new List<Articulo>();
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setearConsulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion as Marca, A.IdCategoria, C.Descripcion as Categoria, A.ImagenUrl, A.Precio From ARTICULOS A, CATEGORIAS C, MARCAS M Where A.IdMarca = M.Id and A.IdCategoria = C.Id");
				datos.ejecutarConsulta();
				while (datos.Lector.Read())
				{
                    lista.Add(leerDatos(datos));
                }
				return lista;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				datos.cerrarConexion();
			}
        }

		public void agregar(Articulo art)
		{
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setearConsulta("Insert into ARTICULOS (Nombre, Codigo, Precio, IdMarca, IdCategoria, ImagenUrl, Descripcion) values (@Nombre, @Codigo, @Precio, @IdMarca, @IdCategoria, @ImagenUrl, @Descripcion)");
				parametros(art, datos);

            }
            catch (Exception ex)
			{
				throw ex;
			}
		}

        public void modificar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
				datos.setearConsulta("Update ARTICULOS set Nombre = @Nombre, Codigo = @Codigo, Precio = @Precio, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Descripcion = @Descripcion Where Id = @Id");
				datos.setearParametros("@Id", art.Id);
				parametros(art, datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		public void eliminar(int id)
		{
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setearConsulta("Delete From ARTICULOS where Id = @Id");
				datos.setearParametros("@Id", id);
				datos.ejecutarConsulta();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void parametros(Articulo art, AccesoDatos datos)
		{
			try
			{
                datos.setearParametros("@Nombre", art.Nombre);
                datos.setearParametros("@Codigo", art.Codigo);
                datos.setearParametros("@Precio", art.Precio);
                datos.setearParametros("@IdMarca", art.Marca.Id);
                datos.setearParametros("@IdCategoria", art.Categoria.Id);
                datos.setearParametros("@ImagenUrl", art.ImagenUrl);
                datos.setearParametros("@Descripcion", art.Descripcion);
                datos.ejecutarConsulta();
            }
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				datos.cerrarConexion();
			}
		}
		public Articulo ultimoRegistro()
		{
			Articulo ultimoArt = new Articulo();
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setearConsulta("Select top (1) A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion as Marca, A.IdCategoria, C.Descripcion as Categoria, A.ImagenUrl, A.Precio From ARTICULOS A, CATEGORIAS C, MARCAS M Where A.IdMarca = M.Id and A.IdCategoria = C.Id Order By A.Id Desc");
				datos.ejecutarConsulta();
				datos.Lector.Read();
				ultimoArt = leerDatos(datos);
                return ultimoArt;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				datos.cerrarConexion();
			}
		}

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
			AccesoDatos datos = new AccesoDatos();
			List<Articulo> lista = new List<Articulo>();
			string consulta = "Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion as Marca, A.IdCategoria, C.Descripcion as Categoria, A.ImagenUrl, A.Precio From ARTICULOS A, CATEGORIAS C, MARCAS M Where A.IdMarca = M.Id and A.IdCategoria = C.Id And ";
            try
			{
				switch(campo)
                {
					case "Nombre":
						switch(criterio)
                        {
							case "Comienza con":
								consulta += "A.Nombre like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "A.Nombre like '%" + filtro + "'";
                                break;
                            case "Contiene":
                                consulta += "A.Nombre like '%" + filtro + "%'";
                                break;
                        }
                        break;

					case "Código":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "A.Codigo like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "A.Codigo like '%" + filtro + "'";
                                break;
                            case "Contiene":
                                consulta += "A.Codigo like '%" + filtro + "%'";
                                break;
                        }
                        break;

                    case "Precio":
                        switch (criterio)
                        {
                            case "Mayor a":
								consulta += "A.Precio > " + filtro;
                                break;
                            case "Menor a":
                                consulta += "A.Precio < " + filtro;
                                break;
                            case "Igual a":
                                consulta += "A.Precio = " + filtro;
                                break;
                        }
                        break;
                }
				datos.setearConsulta(consulta);
				datos.ejecutarConsulta();
                while (datos.Lector.Read())
                {
                    lista.Add(leerDatos(datos));
                }
                return lista;
			}
			catch (Exception ex)
			{
				throw ex;
			}
        }

		public Articulo leerDatos(AccesoDatos datos)
        {
            Articulo aux = new Articulo();
            aux.Marca = new Marca();
            aux.Categoria = new Categoria();
            try
			{
                aux.Id = (int)datos.Lector["Id"];
                aux.Codigo = (string)datos.Lector["Codigo"];
                aux.Nombre = (string)datos.Lector["Nombre"];
                aux.Descripcion = (string)datos.Lector["Descripcion"];
                aux.Marca.Id = (int)datos.Lector["IdMarca"];
                aux.Marca.Detalle = (string)datos.Lector["Marca"];
                aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                aux.Categoria.Detalle = (string)datos.Lector["Categoria"];
                aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                aux.Precio = (decimal)datos.Lector["Precio"];
                return aux;
            }
			catch (Exception ex)
			{
				throw ex;
			}
        }
    }
}
