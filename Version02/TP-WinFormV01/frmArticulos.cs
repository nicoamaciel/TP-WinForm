using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catalogo;
using Dominio;

namespace TP_WinFormV01
{
    public partial class frmArticulos : Form
    {
        private List<Articulos> listaArticulos;
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
            cbCampo.Items.Add("Nombre");
            cbCampo.Items.Add("Categoria");
            cbCampo.Items.Add("Marca");
            cbCampo.Items.Add("Precio");

        }
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ElementosCatalogo articulo = new ElementosCatalogo();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cbCampo.SelectedItem.ToString();
                string criterio = CbCriterio.SelectedItem.ToString();
                string filtro = txtArticulos.Text;
                dgvBuscarArt.DataSource = articulo.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnListaTdo_Click(object sender, EventArgs e)
        {
            dgvBuscarArt.DataSource = null;
            dgvBuscarArt.DataSource = listaArticulos;
        }
        private void btnFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        private void eliminar(bool logico = false)
        {
            ElementosCatalogo negocio = new ElementosCatalogo();
            Articulos seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulos)dgvBuscarArt.CurrentRow.DataBoundItem;
                        negocio.eliminar(seleccionado.ID);

                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cargar()
        {
            ElementosCatalogo negocio = new ElementosCatalogo();
            try
            {
                listaArticulos = negocio.listar();
                dgvBuscarArt.DataSource = listaArticulos;
                //cargarImagen(listaArticulos[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool validarFiltro()
        {
            if (cbCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (CbCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (cbCampo.SelectedItem.ToString() == "Número")
            {
                if (string.IsNullOrEmpty(txtArticulos.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numéricos...");
                    return true;
                }
                if (!(soloNumeros(txtArticulos.Text)))
                {
                    MessageBox.Show("Solo nros para filtrar por un campo numérico...");
                    return true;
                }

            }

            return false;
        }
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }
        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                CbCriterio.Items.Clear();
                CbCriterio.Items.Add("Mayor a");
                CbCriterio.Items.Add("Menor a");
                CbCriterio.Items.Add("Igual a");
            }
            else
            {
                CbCriterio.Items.Clear();
                CbCriterio.Items.Add("Comienza con");
                CbCriterio.Items.Add("Termina con");
                CbCriterio.Items.Add("Contiene");
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dgvBuscarArt.CurrentRow.DataBoundItem;

            frmCargarArt modificar = new frmCargarArt(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

    }
}
