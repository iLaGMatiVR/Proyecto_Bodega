using Proyecto_Bodega;
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
    public partial class frmFacturas : Form
    {

        string monto;
        Factura factura;
        public frmFacturas()
        {
            InitializeComponent();
        }

    
        private void btnHabilitarDetalle_Click_1(object sender, EventArgs e)
        {
            gbxDetalle.Enabled = true;
            gbxCabecera.Enabled = false;

            cboArticulo.Focus();
        }

        private void frmFacturas_Load_1(object sender, EventArgs e)
        {
            dgvFactura.AutoGenerateColumns = true;
            cmbTipoPago.DataSource = Enum.GetValues(typeof(TipoPago));
            cboCliente.DataSource = Cliente.ObtenerClientes();
            cboArticulo.DataSource = Articulo.ObtenerArticulos();
            cboCliente.SelectedItem = null;
            cmbTipoPago.SelectedItem = null;
            cboArticulo.SelectedItem = null;
            gbxDetalle.Enabled = false;
            gbxCabecera.Enabled = true;


            factura = new Factura();

        }


        private void ActualizarLista()
        {

            dgvFactura.DataSource = DetalleFactura.ObtenerDetalleFactura();
            dgvFactura.DataSource = null;
        }

        private void LimpiarFormulario()
        {
            txtNroFactura.Text = "";
            txtTimbrado.Text = "";
            cboCliente.SelectedItem = null;
            cmbTipoPago.SelectedItem = null;
            dtpFechaFactura.Value = System.DateTime.Now;
            cboArticulo.SelectedItem = null;
            txtCantidad.Text = "";
        }


        private Factura ObtenerDatosFormulario()
        {
            Factura factura = new Factura();
            factura.NroFactura = txtNroFactura.Text;
            factura.Timbrado = txtTimbrado.Text;
            factura.Cliente = (Cliente)cboCliente.SelectedItem;
            factura.TipoPago = (TipoPago)cmbTipoPago.SelectedItem;
            factura.FechaFactura = dtpFechaFactura.Value.Date;
            factura.articulo = (Articulo)cboArticulo.SelectedItem;

            return factura;


           
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            //se va tirando los datos del detalle
            DetalleFactura df = new DetalleFactura();
            df.Cantidad = txtCantidad.Text;

            df.Articulo = (Articulo)cboArticulo.SelectedItem;
            factura.detalle_factura.Add(df);
         
            ActualizarLista();

            //realizar calculo monto
            //lblTotalMonto.Text = Convert.ToString(Articulo.Precio_Unit);

            //lineas para la suma
            monto = lblTotalMonto.Text;
            lblTotalMonto.Text = monto + lblTotalMonto;
        }


        /*private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (lstFactura.SelectedItems.Count > 0)
            {
                
                int indice = lstFactura.SelectedIndex;
                Factura f = ObtenerDatosFormulario();
                Factura.ModificarFactura(f, indice);
                ActualizarLista();

            }
            else
            {
                MessageBox.Show("Favor seleccionar de la fila para modificar");
            }


        }*/

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            /*if (this.lstFactura.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila para eliminar");
            }
            else
            {
                Factura f = (Factura)lstFactura.SelectedItem;
                Factura.EliminarFactura(f);
                ActualizarLista();
                LimpiarFormulario();
            }*/


            DetalleFactura f = (DetalleFactura)dgvFactura.CurrentRow.DataBoundItem;
            factura.detalle_factura.Remove(f);
            ActualizarLista();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();


            /*r (gvFactura.RowCount - 1 To 0 Step - 1) ;
                {
                row DataGridViewRow = dgvFactura.Rows();

            dgvFactura.Rows.Remove();

            }*/

            lblTotalMonto.Text = "";


            gbxCabecera.Enabled = true;
            gbxDetalle.Enabled = false;
        }

    
    }
}
