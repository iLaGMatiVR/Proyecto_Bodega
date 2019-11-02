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
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var p = ObtenerDatosFormulario();
            Factura.AgregarFactura(p);
            ActualizarLista();
            LimpiarFormulario();
            txtNroFactura.Focus();
        }

        private void ActualizarLista()
        {
            lstFactura.DataSource = null;
            lstFactura.DataSource = Factura.ObtenerFactura();
        }

        private void LimpiarFormulario()
        {
            txtNroFactura.Text = "";
            txtTimbrado.Text = "";
            txtCliente.Text = "";
            cmbTipoPago.SelectedItem = null;
            dtpFechaFactura.Value = System.DateTime.Now;

        }


        private Factura ObtenerDatosFormulario()
        {
            Factura factura = new Factura();
            factura.NroFactura = txtNroFactura.Text;
            factura.Timbrado = txtTimbrado.Text;
            factura.Nombre = txtCliente.Text;
            factura.TipoPago = (TipoPago)cmbTipoPago.SelectedItem;
            factura.FechaFactura = dtpFechaFactura.Value.Date;

            return factura;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstFactura.SelectedItems.Count > 0)
            {
                int index = lstFactura.SelectedIndex;
                Factura.listaFactura[index] = ObtenerDatosFormulario();
                ActualizarLista();

            }
            else
            {
                MessageBox.Show("Favor seleccionar de la fila para modificar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstFactura.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila para eliminar");
            }
            else
            {
                Factura f = (Factura)lstFactura.SelectedItem;
                Factura.EliminarFactura(f);
                ActualizarLista();
                LimpiarFormulario();
            }
        }

        private void lstFactura_Click(object sender, EventArgs e)
        {
            Factura factura = (Factura)lstFactura.SelectedItem;
            if (factura != null)
            {
                txtNroFactura.Text = factura.NroFactura;
                txtTimbrado.Text = factura.Timbrado;
                txtCliente.Text = factura.Nombre;

                cmbTipoPago.SelectedItem = factura.TipoPago;
                dtpFechaFactura.Value = factura.FechaFactura;

            }
        }

     
    }
}
