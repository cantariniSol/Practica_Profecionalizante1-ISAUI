using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaColombraro.LogicaDeNegocio;

namespace SistemaColombraro.IU.InicioSesion
{
    public partial class Productos : Form
    {

        CN_Productos objetoCN = new CN_Productos();
        private string articulo = null;
        private string codigo = null;
        private bool Editar = false;

        public Productos()
        {
            InitializeComponent();
            timer1.Enabled = true;

        }
        private void Productos_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "CÓDIGO";
            dataGridView1.Columns[2].HeaderText = "NOMBRE";
            dataGridView1.Columns[3].HeaderText = "CATEGORÍA";
            dataGridView1.Columns[4].HeaderText = "PRECIO";
            dataGridView1.Columns[5].HeaderText = "STOCK";
        }
        private void MostrarProductos()
        {

            CN_Productos objeto = new CN_Productos();
            dataGridView1.DataSource = objeto.MostrarProd();
        }
        private void limpiarForm()
        {
            txtCodigo.Clear();
            txtCategoria.Clear();
            txtNombre.Text = "";
            txtPrecio.Clear();
            txtStock.Clear();

        }

        Menu m = new Menu();


        private void button12_Click(object sender, EventArgs e)
        {       
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

       

      
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarPRod(txtCategoria.Text, txtNombre.Text, txtPrecio.Text, txtStock.Text, txtCodigo.Text);
                    MessageBox.Show("Se ha insertado correctamente el nuevo producto");
                    MostrarProductos();
                    limpiarForm();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido insertar el nuevo producto: " + ex);
                }
            }

            if (Editar == true)
            {
                try
                {
                    objetoCN.EditarProd(txtCategoria.Text, txtNombre.Text, txtPrecio.Text, txtStock.Text, txtCodigo.Text, articulo);
                    MessageBox.Show("Se ha editado correctamente el producto");
                    MostrarProductos();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido editado el producto por : " + ex);
                }
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;

                txtNombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                txtCategoria.Text = dataGridView1.CurrentRow.Cells["categoria"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["stock"].Value.ToString();
                txtCodigo.Text = dataGridView1.CurrentRow.Cells["codigo"].Value.ToString();
                articulo = dataGridView1.CurrentRow.Cells["articulo"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¡Está eliminar un producto!", "¡Alerta!", botones, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    codigo = dataGridView1.CurrentRow.Cells["codigo"].Value.ToString();
                    objetoCN.EliminarPRod(codigo);
                    MessageBox.Show("Se ha eliminado el producto correctamente");
                    MostrarProductos();
                }
                else
                    MessageBox.Show("Seleccione una fila por favor");
            }
        }
    }
}
