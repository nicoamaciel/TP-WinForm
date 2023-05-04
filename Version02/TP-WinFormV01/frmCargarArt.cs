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
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP_WinFormV01
{
    public partial class frmCargarArt : Form
    {
        private Articulos articulo = null;
        public frmCargarArt()
        {
            InitializeComponent();
        }
        public frmCargarArt(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
           ElementosCatalogo Art = new ElementosCatalogo();
            try
            {
                if (articulo == null)
                    articulo = new Articulos();
                articulo.Nombre = Nombre.Text;
                articulo.Codigo = Codigo.Text;
                articulo.Descripcion=Descripcion.Text;
                articulo.Precio = decimal.Parse(Precio.Text);
                articulo.Marca = (Marca)CbMarca.SelectedItem;
                articulo.Categoria = (Categorias)CbCategoria.SelectedItem;
                Art.cargarArticulo(articulo);
                MessageBox.Show("Carga Exitosa");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            
        }


        private void IDMarca_KeyPress(object sender, KeyPressEventArgs e)
        {

            if((e.KeyChar >= 32 &&  e.KeyChar <=47) || (e.KeyChar >=58 &&  e.KeyChar <= 255))
            {
                MessageBox.Show("Valor Debe ser Numerico","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void IDCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Valor Debe ser Numerico", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
