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
    public partial class ListarArticulos : Form
    {
        private List<Articulos> listaArt;
        public ListarArticulos()
        {
            InitializeComponent();
        }

        private void ListarArticulos_Load(object sender, EventArgs e)
        {
            listarArticulos articulos = new listarArticulos();
            listaArt = articulos.listar();
            dgvArticulos.DataSource = listaArt;
          
        }
    }
}
