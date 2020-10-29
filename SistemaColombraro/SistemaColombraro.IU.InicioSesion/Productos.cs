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
        private bool Editar = false;
        

        public Productos()
        {
            InitializeComponent();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if(Editar == false){
                try
                {
                    objetoCN.InsertarPRod( txtCategoria.Text, txtNombre.Text, txtPrecio.Text, txtStock.Text, txtCodigo.Text);
                    MessageBox.Show("Se ha insertado correctamente el nuevo producto");
                    MostrarProductos();
                    
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
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido editado el producto por : " + ex);
                }
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           

                if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
           
                txtNombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                txtCategoria.Text = dataGridView1.CurrentRow.Cells["categoria"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["stock"].Value.ToString();
                articulo = dataGridView1.CurrentRow.Cells["articulo"].Value.ToString(); 
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        
    }
}

