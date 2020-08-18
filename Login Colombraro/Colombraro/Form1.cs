using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colombraro
{
    public partial class inicioSesion : Form
    
    {   

        public inicioSesion()
        {
            InitializeComponent();
        }

        private void Crear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Login_Click(object sender, EventArgs e)
        {

            if ((txtUser.Text == "") && (txtPass.Text == ""))
            { 
                if ((txtUser.Text == "admin" ) && (txtPass.Text == "123456")) {
                

                this.Hide();
            }
            }
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }
    }
}
