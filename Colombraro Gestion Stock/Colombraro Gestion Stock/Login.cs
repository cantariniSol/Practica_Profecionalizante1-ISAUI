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
    public partial class panelLogin : Form
    {
        public panelLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form llamaMenu = new Menu();
            llamaMenu.Show(); 
        }
    }
}
