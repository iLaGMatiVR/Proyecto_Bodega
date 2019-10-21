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
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void LimpiarFormulario()
        {
            txtCodProveedor.Text = "";
            txtNombre.Text = "";
            txtRUC.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtContacto.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
