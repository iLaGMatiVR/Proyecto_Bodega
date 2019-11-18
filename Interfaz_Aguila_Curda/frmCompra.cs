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
    public partial class frmCompra : Form
    {
        public frmCompra()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            var c = ObtenerDatosCompra();
            Compra.AgregarCompra(c);
            ActualizarLista();
            LimpiarFormulario();
            txtNroFactura.Focus();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (lstcompra.SelectedItems.Count > 0)
            {
                int index = lstcompra.SelectedIndex;
                Compra.listaCompra[index] = ObtenerDatosCompra();
                ActualizarLista();

            }
            else
            {
                MessageBox.Show("Favor seleccionar de la fila para modificar");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (this.lstcompra.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila para eliminar");
            }
            else
            {
                Compra c = (Compra)lstcompra.SelectedItem;
                Compra.EliminarCompra(c);
                ActualizarLista();
                LimpiarFormulario();
            }

        }

        private void ActualizarLista()
        {
            lstcompra.DataSource = null;
            lstcompra.DataSource = Compra.ObtenerCompra();
        }

        private void LimpiarFormulario()
        {
            txtNroFactura.Text = "";
            txtDireccion.Text = "";
            cmbProveedor.SelectedItem = null;
            cmbMedioPago.SelectedItem = null;
            dtpFechaCompra.Value = System.DateTime.Now;

        }

        private Compra ObtenerDatosCompra()
        {
            Compra compra = new Compra();
            compra.NroFactura = txtNroFactura.Text;
            compra.Proveedor = (Proveedor)cmbProveedor.SelectedItem;
            compra.Direccion = txtDireccion.Text;
            compra.MedioPago = (MedioPago)cmbMedioPago.SelectedItem;
            compra.FechaCompra = dtpFechaCompra.Value.Date;

            return compra;
        }

      

      
        private void lstcompra_Click(object sender, EventArgs e)
        {
            Compra compra = (Compra)lstcompra.SelectedItem;
            if (compra != null)
            {
                txtNroFactura.Text = compra.NroFactura;
                txtDireccion.Text = compra.Direccion;
                cmbProveedor.SelectedItem = compra.Proveedor;

                cmbMedioPago.SelectedItem = compra.MedioPago;
                dtpFechaCompra.Value = compra.FechaCompra;

            }
        }
    }
    }

