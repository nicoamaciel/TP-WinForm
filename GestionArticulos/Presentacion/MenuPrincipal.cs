using Catalogo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionArticulos.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(listarArticulos))
                {
                    return;
                }
            }
            ListarArticulos ventana = new ListarArticulos();
            ventana.ShowDialog();
        }

        private void btnBuscarArticulos_Click(object sender, EventArgs e)
        {
            BuscarArticulo bsq = new BuscarArticulo();
            bsq.ShowDialog();

        }

        private void btnAgregarArticulos_Click(object sender, EventArgs e)
        {
            AgregarArticulo agregar = new AgregarArticulo();
            agregar.ShowDialog();
           // cargar();

        }
    }
}
