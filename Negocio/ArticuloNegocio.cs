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
				datos.setearConsulta("Select A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion as Marca, A.IdCategoria, C.Descripcion as Categoria, A.ImagenUrl, A.Precio From ARTICULOS A, CATEGORIAS C, MARCAS M Where A.IdMarca = M.Id and A.IdCategoria = C.Id");
				datos.ejecutarConsulta();
				while (datos.Lector.Read())
				{
					Articulo aux = new Articulo();
					aux.Marca = new Marca();
					aux.Categoria = new Categoria();
					aux.Codigo = (string)datos.Lector["Codigo"];
					aux.Nombre = (string)datos.Lector["Nombre"];
					aux.Descripcion = (string)datos.Lector["Descripcion"];
					aux.Marca.Id = (int)datos.Lector["IdMarca"];
					aux.Marca.Detalle = (string)datos.Lector["Marca"];
					aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
					aux.Categoria.Detalle = (string)datos.Lector["Categoria"];
					aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
					aux.Precio = (decimal)datos.Lector["Precio"];
					lista.Add(aux);
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

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
