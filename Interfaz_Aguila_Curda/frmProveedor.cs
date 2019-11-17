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



		private void btnAgregar_Click_1(object sender, EventArgs e)
		{
			Proveedor proveedor = new Proveedor();
			proveedor.Nombre = txtNombre.Text;
			proveedor.NroDocumento = txtRUC.Text;
			proveedor.Telefono = txtTelefono.Text;
			proveedor.Direccion = txtDireccion.Text;
			proveedor.PersonaContacto = txtContacto.Text;

			Proveedor.AgregarProveedor(proveedor);
			LimpiarFormulario();
			ActualizarListaProveedores();
		}

		private void ActualizarListaProveedores()
        {
            lstProveedor.DataSource = null;
            lstProveedor.DataSource = Proveedor.ObtenerProveedores();
        }




        private Proveedor ObtenerDatosFormulario()
        {
            Proveedor proveedor = new Proveedor();


			if (!string.IsNullOrEmpty(txtCodProveedor.Text))
			{
				proveedor.CodProveedor = Convert.ToInt16(txtCodProveedor.Text);
			}
			
            proveedor.Nombre = txtNombre.Text;
			proveedor.NroDocumento = txtRUC.Text;
			proveedor.Telefono = txtTelefono.Text;
            proveedor.Direccion = txtDireccion.Text;
            proveedor.PersonaContacto = txtContacto.Text;
            


            return proveedor;
        }

       
        private void lstProveedor_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = (Proveedor)lstProveedor.SelectedItem;
            if (proveedor != null)
            {
                txtCodProveedor.Text = Convert.ToString(proveedor.CodProveedor);
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
                MessageBox.Show("Favor seleccione una fila");
            }
            else
            {
                Proveedor p = (Proveedor)lstProveedor.SelectedItem;
                Proveedor.EliminarProveedor(p);
                ActualizarListaProveedores();
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
				//int index = lstProveedor.SelectedIndex;
				//Proveedor.listaProveedor[index] = ObtenerDatosFormulario();
				int index = lstProveedor.SelectedIndex;
				Proveedor p = ObtenerDatosFormulario();
				Proveedor.ModificarProveedor(index, p);
				ActualizarListaProveedores();

            }
            else
            {
                MessageBox.Show("Favor seleccionar de la fila para modificar");
            }
        }

		private void frmProveedor_Load(object sender, EventArgs e)
		{
			ActualizarListaProveedores();
		}
	}
}
