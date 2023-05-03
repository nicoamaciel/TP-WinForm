using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Catalogo;

namespace GestionArticulos.Presentacion
{
    public partial class BuscarArticulo : Form
    {

        private List<Articulos> listaArt2;

        public BuscarArticulo()
        {
            InitializeComponent();
            listarArticulos articulos = new listarArticulos();
            listaArt2 = articulos.listar(); 
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            
            List<Articulos> listaFiltrada;
            listaFiltrada = listaArt2.FindAll(Buscar => Buscar.Codigo == btnBuscar.Text);
            dgvBuscar.DataSource = listaFiltrada;


        }
    }
}
