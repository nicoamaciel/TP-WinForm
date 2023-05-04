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



       

        public void cargarArticulo(string Nombre,string Codigo,string Descripcion,int IDMarca,int IDCategoria, decimal Precio)
        {

            Articulos aux = new Articulos();

            aux.Nombre = Nombre;
            aux.Codigo = Codigo;
            aux.Descripcion = Descripcion;
            aux.IdMarca = IDMarca;
            aux.IdCategoria = IDCategoria;
            aux.Precio = Precio;

                // Crear instancia de AccesoDatos
                AccesoDatos datos = new AccesoDatos();

                try
                {
               

                    // Setear consulta SQL para insertar nuevo artículo
                    datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                                         "VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");

                    // Setear parámetros de la consulta SQL
                    datos.Comando.Parameters.AddWithValue("@Codigo", aux.Codigo);
                    datos.Comando.Parameters.AddWithValue("@Nombre", aux.Nombre);
                    datos.Comando.Parameters.AddWithValue("@Descripcion", aux.Descripcion);
                    datos.Comando.Parameters.AddWithValue("@IdMarca", aux.IdMarca);
                    datos.Comando.Parameters.AddWithValue("@IdCategoria", aux.IdCategoria);
                    datos.Comando.Parameters.AddWithValue("@Precio", aux.Precio);

                    // Ejecutar consulta SQL
                    datos.ejecutarLectura();

                    // Cerrar conexión
                    datos.cerrarConexion();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            

        }



        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdMarca, A.Precio from ARTICULOS as A");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.ID = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.IdCategoria = (int)datos.Lector["IdMarca"];
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


    }
}
