using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaStockColombraro
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textUser_Enter(object sender, EventArgs e)
        {
            if(textUser.Text == "Usuario")
            {
                textUser.Text = "";
                textUser.ForeColor = Color.Black;
            }
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            if(textUser.Text == "")
            {
                textUser.Text = "Usuario";
                textUser.ForeColor = Color.DimGray;
            }
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textPass_Enter(object sender, EventArgs e)
        {
            if (textPass.Text == "Contraseña")
            {
                textPass.Text = "";
                textPass.ForeColor = Color.Black;
                textPass.UseSystemPasswordChar = true;
            }
        }

        private void textPass_Leave(object sender, EventArgs e)
        {
            if (textPass.Text == "")
            {
                textPass.Text = "Contraseña";
                textPass.ForeColor = Color.DimGray;
                textPass.UseSystemPasswordChar = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Presentacion p = new Presentacion();
            p.lblUserName.Text = textUser.Text;
            this.Hide(); //Oculta el formulario Login.
            p.ShowDialog();
        }
    }
}
