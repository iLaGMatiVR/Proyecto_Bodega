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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }


        private void LimpiarFormulario()
        {
            txtCodCliente.Text = "";
            txtNombre.Text = "";
            txtCI.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            dtpFechaNac.Value = DateTime.Now;
            rdbFemenino.Checked = false;
            rdbMasculino.Checked = false;
        }




        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

    }
}
