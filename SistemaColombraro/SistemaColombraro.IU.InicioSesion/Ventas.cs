using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaColombraro.IU.InicioSesion
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }
             

        private void button12_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            this.Hide();
            m.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblHora.Refresh();
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblFecha.Refresh();
        }
    }
}
