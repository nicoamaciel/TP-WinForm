using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    public class CatalogoImagenes
    {
        public List<Imagenes> listar()
        {
            List<Imagenes> lista = new List<Imagenes>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select ID,IdArticulo, ImagenURL from IMAGENES ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagenes aux = new Imagenes();
                        aux.ID = (int)datos.Lector["Id"];
                        aux.ImagenURL = (string)datos.Lector["ImagenURL"];
                        lista.Add(aux);
                }
                datos.cerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Imagenes> listar(Articulos articulos)
        {
            List<Imagenes> lista = new List<Imagenes>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select ID,IdArticulo, ImagenURL from IMAGENES ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagenes aux = new Imagenes();
                    if (articulos.ID == (int)datos.Lector["IdArticulo"])
                    {
                        aux.ID = (int)datos.Lector["Id"];
                        aux.ImagenURL = (string)datos.Lector["ImagenURL"];
                        lista.Add(aux);
                    }

                }
                datos.cerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //



        //
    }
}
