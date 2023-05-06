using Catalogo;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TP_WinFormV01
{
    public partial class frmModificador : Form
    {
        private List<Articulos> listaArticulos;
        private List<Imagenes> listarImagenes;
        private Articulos articulo = null;

        public frmModificador()
        {
            InitializeComponent();
        }

        private void frmModificador_Load(object sender, EventArgs e)
        {
            ElementosCatalogo articulos = new ElementosCatalogo();
            try
            {
                CbxArticulos.DataSource = articulos.listar();
                CbxArticulos.ValueMember = "Id";
                CbxArticulos.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string Url)
        {

            try
            {
                PbxImagen.Load(Url);
            }
            catch (Exception ex)
            {
                PbxImagen.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
        private void cargar()
        {
            ElementosCatalogo negocio = new ElementosCatalogo();
            CatalogoImagenes imagen = new CatalogoImagenes();
            try
            {
                listaArticulos = negocio.listar();
                DgvArticulo.DataSource = listaArticulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            ElementosCatalogo articulo = new ElementosCatalogo();
            try
            {
                string campo = CbxArticulos.SelectedItem.ToString();
                DgvArticulo.DataSource = articulo.filtrar(campo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnModificar_Click_1(object sender, EventArgs e)
        {
            CatalogoImagenes imagen = new CatalogoImagenes();
            Articulos seleccionado;
            seleccionado = (Articulos)DgvArticulo.CurrentRow.DataBoundItem;
            Imagenes ImgSeleccionada;
            listarImagenes = imagen.listar(seleccionado);

            frmCargarArt modificar = new frmCargarArt(seleccionado, listarImagenes[0]);
                modificar.ShowDialog();
                cargar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ElementosCatalogo negocio = new ElementosCatalogo();
            CatalogoImagenes imagen = new CatalogoImagenes();
            Articulos ArtSeleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    ArtSeleccionado = (Articulos)DgvArticulo.CurrentRow.DataBoundItem;
                    imagen.eliminar(ArtSeleccionado.ID);
                    negocio.eliminar(ArtSeleccionado.ID);

                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void DgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            CatalogoImagenes imagen = new CatalogoImagenes();
            Articulos ArtSeleccionado;

            ArtSeleccionado = (Articulos)DgvArticulo.CurrentRow.DataBoundItem;
            listarImagenes = imagen.listar(ArtSeleccionado);
            cargarImagen(listarImagenes[0].ImagenURL);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
