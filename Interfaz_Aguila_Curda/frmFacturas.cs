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
using CapaComun.Cache;

namespace Interfaz_Aguila_Curda
{
    public partial class frmFacturas : Form
    {

        int monto;
        Factura factura;
        public frmFacturas()
        {
            InitializeComponent();
        }

    
        private void btnHabilitarDetalle_Click_1(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                gbxDetalle.Enabled = true;
                gbxCabecera.Enabled = false;
                cboArticulo.Focus();
            }
        }
        private bool ValidarCampos()
        {
            try
            {
                int result = int.Parse(txtNroFactura.Text);
            }
            catch
            {
                MessageBox.Show("Por favor ingrese un valor numerico como Nro de Factura", "Error");
                txtNroFactura.Text = "";
                txtNroFactura.SelectAll();
                txtNroFactura.Focus();
                return false;
            }
            try
            {
                int result = int.Parse(txtTimbrado.Text);
            }
            catch
            {
                MessageBox.Show("Por favor ingrese un valor numerico como Timbrado", "Error");
                txtTimbrado.Text = "";
                txtTimbrado.SelectAll();
                txtTimbrado.Focus();
                return false;
            }

            var cli = (Cliente)cboCliente.SelectedItem;
            if (cli == null)
            {
                MessageBox.Show("Por favor seleccione un Cliente", "Error");
                cboCliente.Focus();
                return false;
            }
            var fechaIncorrecta = new DateTime(2100, 1, 1);

            if (dtpFechaFactura.Value < DateTime.Now || dtpFechaFactura.Value > DateTime.Parse("01/01/2100") || dtpFechaFactura.Value > fechaIncorrecta)
            {
                MessageBox.Show("Por favor ingrese una fecha de factura correcta", "Error");
                dtpFechaFactura.Focus();
                return false;
            }
            if (cmbTipoPago.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un Tipo de Pago", "Error");
                cmbTipoPago.Focus();
                return false;
            }
            
            return true;
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
            lblTotalMonto.Text = "";
            txtPrecio.Text = "";
            factura = new Factura();
            if (UserLoginCache.Cargo == Cargos.Cajero)
            {
                
                
                btnEliminar.Enabled = false;


            }

        }


        private void ActualizarLista()
        {
            dgvFactura.DataSource = null;
            dgvFactura.DataSource = factura.detalle_factura;
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
            lblTotalMonto.Text = "";
            txtPrecio.Text = "";
        }
       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDetalle())
            {
                //se va tirando los datos del detalle
                DetalleFactura df = new DetalleFactura();
                df.Cantidad = Convert.ToDouble(txtCantidad.Text);
                df.Articulo = (Articulo)cboArticulo.SelectedItem;
                df.Precio = Convert.ToDouble(txtPrecio.Text);
                factura.detalle_factura.Add(df);
                monto = monto + (int.Parse(txtCantidad.Text) * (int.Parse(txtPrecio.Text)));
                lblTotalMonto.Text = monto.ToString();
                ActualizarLista();
            }

        }
        private bool ValidarDetalle()
        {
            var art = (Articulo)cboArticulo.SelectedItem;
            if (art == null)
            {
                MessageBox.Show("Por favor seleccione un Articulo", "Error");
                cboArticulo.Focus();
                return false;
            }
            try
            {
                int result = int.Parse(txtCantidad.Text);
            }
            catch
            {
                MessageBox.Show("Por favor ingrese un valor numerico en Cantidad", "Error");
                txtCantidad.Text = "";
                txtCantidad.SelectAll();
                txtCantidad.Focus();
                return false;
            }
            
            return true;
        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
           
            DetalleFactura f = (DetalleFactura)dgvFactura.CurrentRow.DataBoundItem;
            factura.detalle_factura.Remove(f);
            ActualizarLista();
            monto = monto - (int.Parse(txtCantidad.Text) * (int.Parse(txtPrecio.Text)));
            lblTotalMonto.Text = monto.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();

            lblTotalMonto.Text = "";
            gbxCabecera.Enabled = true;
            gbxDetalle.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() && ValidarDetalle() && ValidarMonto())
            {
                factura.NroFactura = Convert.ToInt32(txtNroFactura.Text);
                factura.Timbrado = Convert.ToInt32(txtTimbrado.Text);
                factura.Cliente = (Cliente)cboCliente.SelectedItem;
                factura.TipoPago = (TipoPago)cmbTipoPago.SelectedItem;
                factura.FechaFactura = dtpFechaFactura.Value.Date;
                factura.MontoTotal = Convert.ToDouble(lblTotalMonto.Text);
                Factura.AgregarFactura(factura);
                MessageBox.Show("La factura ha sido guardado con éxito");
                LimpiarFormulario();
                dgvFactura.DataSource = null;
                dtpFechaFactura.Value = System.DateTime.Now;
                cboArticulo.SelectedItem = null;
                cboCliente.SelectedItem = null;

                factura = new Factura();
                gbxCabecera.Enabled = true;
                gbxDetalle.Enabled = false;
            }
        }
        private bool ValidarMonto()
        {
            if (String.IsNullOrWhiteSpace(lblTotalMonto.Text))
            {
                MessageBox.Show("El monto total no puede estar vacío, favor calcular", "Error");
                lblTotalMonto.Focus();
                return false;
            }
            return true;
        }

        private void cboArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Articulo articulo = (Articulo)cboArticulo.SelectedItem;
            if (articulo != null)
            {
                txtPrecio.Text = Convert.ToString(articulo.Precio_Unit);
            }
        }
    }
}
