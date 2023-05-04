using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Dominio;

namespace Catalogo
{
    public class ElementosCatalogo
    {
        public void cargarArticulo(Articulos nuevos)
        {
                // Crear instancia de AccesoDatos
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    // Setear consulta SQL para insertar nuevo artículo
                    datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                          "VALUES ('"+nuevos.Codigo +"', '"+ nuevos.Nombre +"','"+ nuevos.Descripcion +"',"+ " @IdMarca, @IdCategoria,"+ nuevos.Precio +")");

                    // Setear parámetros de la consulta SQL
                    datos.Comando.Parameters.AddWithValue("@IdMarca", nuevos.Marca.ID);
                    datos.Comando.Parameters.AddWithValue("@IdCategoria", nuevos.Categoria.ID);
                    // Ejecutar consulta SQL
                    datos.ejecutarLectura();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    // Cerrar conexión
                    datos.cerrarConexion();
                }
            

        }



        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, A.Precio from ARTICULOS as A");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.ID = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Categoria = new Categorias();
                    aux.Categoria.Descripcion = (string)datos.Lector["Descripcion"];
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

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
