using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_WinFormV01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

            if (txtUser.Text == "admin" && txtContraseña.Text == "admin")
            {

                MessageBox.Show("acceso Permitido");

                this.Close();


                // Abrir el FormMenu
                frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
                menuPrincipal.ShowDialog();


            }
            else
            {


                MessageBox.Show("Credenciales Incorrectas reintente");


            }

        }
    }
}
