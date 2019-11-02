using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Bodega;

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

        
       
        private void ActualizarLista()
        {
            lstProveedor.DataSource = null;
            lstProveedor.DataSource = Proveedor.ObtenerProveedor();
        }




        private Proveedor ObtenerDatosFormulario()
        {
            Proveedor proveedor = new Proveedor();
            proveedor.CodProveedor = txtCodProveedor.Text;
            proveedor.Nombre = txtNombre.Text;
            proveedor.Telefono = txtTelefono.Text;
            proveedor.Direccion = txtDireccion.Text;
            proveedor.PersonaContacto = txtContacto.Text;
            proveedor.NroDocumento = txtRUC.Text;


            return proveedor;
        }

       
        private void lstProveedor_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = (Proveedor)lstProveedor.SelectedItem;
            if (proveedor != null)
            {
                txtCodProveedor.Text = proveedor.CodProveedor;
                txtRUC.Text = proveedor.NroDocumento;
                txtNombre.Text = proveedor.Nombre;
                txtTelefono.Text = proveedor.Telefono;
                txtDireccion.Text = proveedor.Direccion;
                txtContacto.Text = proveedor.PersonaContacto;

            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (this.lstProveedor.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila para eliminar");
            }
            else
            {
                Proveedor pro = (Proveedor)lstProveedor.SelectedItem;
                Proveedor.EliminarProveedor(pro);
                ActualizarLista();
                LimpiarFormulario();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstProveedor.SelectedItems.Count > 0)
            {
                int index = lstProveedor.SelectedIndex;
                Proveedor.listaProveedor[index] = ObtenerDatosFormulario();
                ActualizarLista();

            }
            else
            {
                MessageBox.Show("Favor seleccionar de la fila para modificar");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var pro = ObtenerDatosFormulario();
            Proveedor.AgregarProveedor(pro);
            ActualizarLista();
            LimpiarFormulario();
            txtCodProveedor.Focus();
        }
    }
}
