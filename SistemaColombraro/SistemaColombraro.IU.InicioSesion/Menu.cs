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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¡Está por cerrar la aplicación!", "¡Alerta!", botones, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
   
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Desea cerrar sesión? ", "Cerrar sesión", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
            this.Hide();
            p.lblUserProd.Text = lblUserMenu.Text;
            p.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas v = new Ventas();
            this.Hide();
            v.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            this.Hide();
            c.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes r = new Reportes();
            this.Hide();
            r.ShowDialog();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            Compras com = new Compras();
            this.Hide();
            com.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedor pr = new Proveedor();
            this.Hide();
            pr.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            this.Hide();
            u.ShowDialog();
        }
    }
}
