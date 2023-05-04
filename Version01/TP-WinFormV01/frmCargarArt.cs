using Catalogo;
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
        public frmCargarArt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        

        }

        private void frmCargarArt_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           ElementosCatalogo Art = new ElementosCatalogo();
            Art.cargarArticulo(Nombre.Text, Codigo.Text, Descripcion.Text, int.Parse(IDMarca.Text), int.Parse(IDCategoria.Text), decimal.Parse(Precio.Text));


            MessageBox.Show("Carga Exitosa");
;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Codigo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Precio_TextChanged(object sender, EventArgs e)
        {






        }

        private void IDMarca_TextChanged(object sender, EventArgs e)
        {
           



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

        private void lblCod_Click(object sender, EventArgs e)
        {

        }

        private void Precio_KeyPress(object sender, KeyPressEventArgs e)
        {


            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {

                MessageBox.Show("Valor Debe ser Numerico", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }



        }
    }
}
