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
using System.Xml.Linq;
using System.Configuration;
using Catalogo;

namespace GestionArticulos.Presentacion
{
    public partial class AgregarArticulo : Form
    {
        private Articulos articulo = null;
        private OpenFileDialog archivo = null;
        public AgregarArticulo()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            listarArticulos negocio = new listarArticulos();
            try
            {
                if (articulo == null)
                    articulo = new Articulos();

                articulo.Codigo = textCodigo.Text;
                articulo.Nombre = textNombre.Text;
                articulo.Categoria= (Categorias)CB_Categoria.SelectedItem;
                articulo.Marca = (Marcas)CB_Marca.SelectedItem;
                articulo.Descripcion = textDescripcion.Text;
                articulo.Precio = decimal.Parse(textPrecio.Text);

                if (articulo.ID != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }
                
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            ListarCategorias Cat = new ListarCategorias();
            ListarMarcas Marcas = new ListarMarcas();
            try
            {
                CB_Categoria.DataSource = Cat.listar();
                CB_Categoria.ValueMember = "Id";
                CB_Categoria.DisplayMember = "Descripcion";
                CB_Marca.DataSource = Marcas.listar();
                CB_Marca.ValueMember = "Id";
                CB_Marca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    textCodigo.Text = articulo.Codigo.ToString();
                    textNombre.Text = articulo.Nombre;
                    textDescripcion.Text = articulo.Descripcion;
                    CB_Categoria.SelectedValue = articulo.Categoria.ID;
                    CB_Marca.SelectedValue = articulo.Marca.ID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
