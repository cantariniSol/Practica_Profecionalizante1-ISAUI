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
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity < 1) this.Opacity += 0.5;
                progressBar1.Value += 1;
                if(progressBar1.Value == 100)
                {
                    timer1.Stop();
                    timer2.Start();
                }
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if(this.Opacity == 0)
            {
                timer2.Stop();
                Menu m = new Menu();
                this.Hide(); //Oculta el formulario Login.
                m.ShowDialog();

            }
        }

        private void Presentacion_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
           
        }
    }
}
