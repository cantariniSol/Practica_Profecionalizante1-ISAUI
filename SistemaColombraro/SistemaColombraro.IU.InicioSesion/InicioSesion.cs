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
    public partial class InicioSesion : Form
    {
        String user = "Maria Sol";
        String pass = "0303";
        public InicioSesion()
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

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if( txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black; 
                
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.UseSystemPasswordChar = true;

            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.Black;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)

        {
            if (txtUser.Text == "Usuario" && txtPass.Text == "Contraseña")
            {
                MessageBox.Show("¡El usuario y la contraseña no han sido ingresados! ");
                errorProvider1.SetError(txtUser, "Igrese usuario");
                errorProvider2.SetError(txtPass, "Ingrese contraseña");
                return;
            }
            else
            {
                if (txtUser.Text == "Usuario" && txtPass.Text == "Contraseña")
                {
                    MessageBox.Show("¡El usuario y la contraseña no han sido ingresados! ");
                    errorProvider1.SetError(txtUser, "Igrese usuario");
                    errorProvider2.SetError(txtPass, "Ingrese contraseña");
                    txtPass.UseSystemPasswordChar = true;
                }

                if (txtUser.Text != user || txtPass.Text != pass)
                {
                    if (txtUser.Text != user)
                    {
                        MessageBox.Show("¡El usuario ingresado es incorrecto! ");
                        errorProvider1.SetError(txtUser, "¡El usuario ingresado es incorrecto! ");
                        errorProvider2.Dispose();
                        txtUser.Clear();
                        txtUser.Focus();
                        return;
                    }

                    else if (txtPass.Text != pass)
                    {
                        MessageBox.Show("¡La contraseña ingresada es incorrecta! ");
                        errorProvider2.SetError(txtPass, "¡La contraseña ingresada es incorrecta! ");
                        txtPass.UseSystemPasswordChar = true;
                        errorProvider1.Dispose();
                        txtPass.Clear();
                        txtPass.Focus();
                        return;
                    }
                }
                else
                {

                    errorProvider1.Dispose();
                    errorProvider2.Dispose();
                    Bienvenida form01 = new Bienvenida();
                    form01.lblUser.Text = txtUser.Text;
                    this.Hide();
                    form01.ShowDialog();

                }
            }

           
        }

        
    }
}
