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
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            var p = ObtenerDatosFormulario();
            Factura.AgregarFactura(p);
            ActualizarLista();
            LimpiarFormulario();
            txtFactura.Focus();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (lstcompra.SelectedItems.Count > 0)
            {
                int index = lstcompra.SelectedIndex;
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

            if (this.lstcompra.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila para eliminar");
            }
            else
            {
                Factura f = (Factura)lstcompra.SelectedItem;
                Factura.EliminarFactura(f);
                ActualizarLista();
                LimpiarFormulario();
            }

        }

        private void ActualizarLista()
        {
            lstcompra.DataSource = null;
            lstcompra.DataSource = Factura.ObtenerFactura();
        }

        private void LimpiarFormulario()
        {
            txtFactura.Text = "";
            txtTimbrado.Text = "";
            txtProveedor.Text = "";
            cmbTipoPago.SelectedItem = null;
            dtpFechaFactura.Value = System.DateTime.Now;

        }

        private Factura ObtenerDatosFormulario()
        {
            Factura factura = new Factura();
            factura.NroFactura = txtFactura.Text;
            factura.Timbrado = txtTimbrado.Text;
            factura.Nombre = txtProveedor.Text;
            factura.TipoPago = (TipoPago)cmbTipoPago.SelectedItem;
            factura.FechaFactura = dtpFechaFactura.Value.Date;

            return factura;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Factura factura = (Factura)lstcompra.SelectedItem;
            if (factura != null)
            {
                txtFactura.Text = factura.NroFactura;
                txtTimbrado.Text = factura.Timbrado;
                txtProveedor.Text = factura.Nombre;

                cmbTipoPago.SelectedItem = factura.TipoPago;
                dtpFechaFactura.Value = factura.FechaFactura;

            }
        }
    }
}
