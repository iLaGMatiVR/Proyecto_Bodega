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
            lstCliente.SelectedItem = 0;

        }






        private Cliente ObtenerDatosFormulario()
        {
            Cliente cliente = new Cliente();
            if (!string.IsNullOrEmpty(txtCodCliente.Text))
            {
                cliente.CodCliente = Convert.ToInt16(txtCodCliente.Text);
            }


            cliente.Nombre = txtNombre.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.NroDocumento = txtCI.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Sexo = lstSexo.Text;



            return cliente;
        }

        private void ActualizarListaCliente()
        {
            lstCliente.DataSource = null;
            lstCliente.DataSource = Cliente.ObtenerClientes();
        }




        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstCliente.SelectedItems.Count > 0)
            {
                //int index = lstCliente.SelectedIndex;
                //Cliente.listaCliente[index] = ObtenerDatosFormulario();
                int index = lstCliente.SelectedIndex;
                Cliente c = ObtenerDatosFormulario();
                Cliente.ModificarCliente(index, c);
                ActualizarListaCliente();

            }
            else
            {
                MessageBox.Show("Favor seleccionar de la fila para modificar");
            }
        }



        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (this.lstCliente.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila para eliminar");
            }
            else
            {
                Cliente c = (Cliente)lstCliente.SelectedItem;
                Cliente.EliminarCliente(c);
                ActualizarListaCliente();
                LimpiarFormulario();
            }
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.NroDocumento = txtCI.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Sexo = lstSexo.Text;

            Cliente.AgregarCliente(cliente);
            LimpiarFormulario();
            ActualizarListaCliente();
        }

       

        private void frmCliente_Load(object sender, EventArgs e)
        {
            ActualizarListaCliente();
        }

        private void lstCliente_Click_1(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)lstCliente.SelectedItem;
            if (cliente != null)
            {
                txtCodCliente.Text = Convert.ToString(cliente.CodCliente);
                txtNombre.Text = cliente.Nombre;
                txtCI.Text = cliente.NroDocumento;
                txtDireccion.Text = cliente.Direccion;
                txtTelefono.Text = cliente.Telefono;


            }
        }
    }

}

