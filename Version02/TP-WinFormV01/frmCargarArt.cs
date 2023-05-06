using Catalogo;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP_WinFormV01
{
    public partial class frmCargarArt : Form
    {
        private OpenFileDialog archivo = null;
        private Articulos articulo = null;
        private Imagenes imagenes = null;
        public frmCargarArt()
        {
            InitializeComponent();
        }
        public frmCargarArt(Articulos articulo,Imagenes imagen)
        {
            InitializeComponent();
            this.articulo = articulo;
            this.imagenes = imagen;
            Text = "Modificar Articulo";
        }


        private void btnCargar_Click_1(object sender, EventArgs e)
        {
           ElementosCatalogo Art = new ElementosCatalogo();
            CatalogoImagenes img = new CatalogoImagenes();
            try
            {
                if (articulo == null)
                articulo = new Articulos();
                imagenes = new Imagenes();
                articulo.Nombre = Nombre.Text;
                articulo.Codigo = Codigo.Text;
                articulo.Descripcion=Descripcion.Text;
                articulo.Precio = decimal.Parse(Precio.Text);
                articulo.Marca = (Marca)CbMarca.SelectedItem;
                articulo.Categoria = (Categorias)CbCategoria.SelectedItem;
                if (articulo.ID != 0)
                {
                    Art.modificarArticulo(articulo);
                    imagenes.ImagenURL = txtImagen.Text;
                    img.modificarImagen(imagenes);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    Art.cargarArticulo(articulo);
                    imagenes.IDArticulo = articulo.ID;
                    imagenes.ImagenURL = txtImagen.Text;
                    img.cargarImagenes(imagenes);
                    MessageBox.Show("Agregado exitosamente");
                }
                
                Close();

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {

                MessageBox.Show("Valor Debe ser Numerico", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmCargarArt_Load(object sender, EventArgs e)
        {
            CatalogoCategoria categoria = new CatalogoCategoria();
            CatalogoMarcas marcas = new CatalogoMarcas();
            try
            {
            CbCategoria.DataSource = categoria.listar();
            CbCategoria.ValueMember = "Id";
            CbCategoria.DisplayMember = "Descripcion";
            
            CbMarca.DataSource = marcas.listar();
            CbMarca.ValueMember = "Id";
            CbMarca.DisplayMember = "Descripcion";
            if (articulo != null)
            {
                txtImagen.Text = imagenes.ToString();
                    imagenes.ID = articulo.ID;
                    imagenes.IDArticulo = articulo.ID;
                Codigo.Text = articulo.Codigo;
                Nombre.Text = articulo.Nombre;
                Descripcion.Text = articulo.Descripcion;
                CbCategoria.SelectedValue = articulo.Categoria.ID;
                CbMarca.SelectedValue = articulo.Marca.ID;
                Precio.Text = articulo.Precio.ToString();
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                //guardo la imagen
                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
            }

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                PbxImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                PbxImagen.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
    }
}
