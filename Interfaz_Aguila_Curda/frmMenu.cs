using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Aguila_Curda
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void tsmCliente_Click(object sender, EventArgs e)
        {
            frmCliente form = new frmCliente();
            form.Show();
        }

        private void tsmProveedor_Click(object sender, EventArgs e)
        {
            frmProveedor form = new frmProveedor();
            form.Show();
        }

      



        private void tsmArticulo_Click(object sender, EventArgs e)
        {
            frmArticulo form = new frmArticulo();
            form.Show();
        }

        private void tsmDevolucion_Click_1(object sender, EventArgs e)
        {
            frmDevolucion form = new frmDevolucion();
            form.Show();
        }

        private void tsmFactura_Click(object sender, EventArgs e)
        {
            frmFacturas form = new frmFacturas();
            form.Show();
        }

        private void tsmCompra_Click(object sender, EventArgs e)
        {
            frmCompra form = new frmCompra();
            form.Show();
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
     

       
    
}
