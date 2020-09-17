using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colombraro_Gestion_Stock
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VentasTxt_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form llamaBaseDatos = new BasedDatostxt();
            llamaBaseDatos.Show();
        }

        private void comprastxt_Click(object sender, EventArgs e)
        {
            Form lamaCompras = new comprastxt();
            lamaCompras.Show();
        }

        private void Exittxt_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
            
        }

        private void Clientestxt_Click(object sender, EventArgs e)
        {
            Form llamaClientes = new clientes();
            llamaClientes.Show(); 
        }

        private void Stocktxt_Click(object sender, EventArgs e)
        {
            Form llamaStck = new Stock();
            llamaStck.Show(); 
        }
    }
}
