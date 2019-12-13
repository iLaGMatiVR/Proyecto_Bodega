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
        int total;
        Compra compra;
        public frmCompra()
        {
            InitializeComponent();
        }

        private void btnHabilitarItems_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                gbxDetalle.Enabled = true;
                gbxCabecera.Enabled = false;
                cboArticulo.Focus();
            }
        }

        private bool Validar()
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


            var pro = (Proveedor)cmbProveedor.SelectedItem;
            if (pro == null)
            {
                MessageBox.Show("Por favor seleccione un Proveedor", "Error");
                cmbProveedor.Focus();
                return false;
            }


            if (cmbMedioPago.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un Medio de Pago", "Error");
                cmbMedioPago.Focus();
                return false;
            }

            var fechaIncorrecta = new DateTime(2100, 1, 1);
            if (dtpFechaCompra.Value < DateTime.Now || dtpFechaCompra.Value > DateTime.Parse("01/01/2100") || dtpFechaCompra.Value > fechaIncorrecta)
            {
                MessageBox.Show("Por favor ingrese una fecha de compra correcta", "Error");
                dtpFechaCompra.Focus();
                return false;
            }


            return true;
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            dgvCompra.AutoGenerateColumns = true;
            cmbMedioPago.DataSource = Enum.GetValues(typeof(TipoPago));
            cmbProveedor.DataSource = Proveedor.ObtenerProveedores();
            cboArticulo.DataSource = Articulo.ObtenerArticulos();
            cmbProveedor.SelectedItem = null;
            cmbMedioPago.SelectedItem = null;
            cboArticulo.SelectedItem = null;
            gbxDetalle.Enabled = false;
            gbxCabecera.Enabled = true;
            lblTotalMonto.Text = "";
            txtCosto.Text = "";
            compra = new Compra();

            //LOGIN MATIAS
            /*if (UserLoginCache.Cargo == Cargos.Cajero)
            {


                btnEliminar.Enabled = false;


            }*/

        }


        private void ActualizarLista()
        {
            dgvCompra.DataSource = null;
            dgvCompra.DataSource = compra.detalle_compra;
        }


        private void LimpiarFormulario()
        {
            txtNroFactura.Text = "";
            txtDireccion.Text = "";
            cmbMedioPago.SelectedItem = null;
            cmbProveedor.SelectedItem = null;
            dtpFechaCompra.Value = System.DateTime.Now;
            cboArticulo.SelectedItem = null;
            txtCantidad.Text = "";
            lblTotalMonto.Text = "";
            txtCosto.Text = "";
        }

        private void btnAgre_Click(object sender, EventArgs e)
        {
            if (ValidarDetalle())
            {
                //se va tirando los datos del detalle
                DetalleCompra dc = new DetalleCompra();
                dc.Cantidad = Convert.ToDouble(txtCantidad.Text);
                dc.Articulo = (Articulo)cboArticulo.SelectedItem;
                dc.Costo = Convert.ToDouble(txtCosto.Text);
                compra.detalle_compra.Add(dc);
                total = total + (int.Parse(txtCantidad.Text) * (int.Parse(txtCosto.Text)));
                lblTotalMonto.Text = total.ToString();
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

        private void btnElim_Click(object sender, EventArgs e)
        {
            DetalleCompra c = (DetalleCompra)dgvCompra.CurrentRow.DataBoundItem;
            compra.detalle_compra.Remove(c);
            ActualizarLista();
            total = total - (int.Parse(txtCantidad.Text) * (int.Parse(txtCosto.Text)));
            lblTotalMonto.Text = total.ToString();
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
            if (Validar() && ValidarDetalle() && ValidarMonto())
            {
                compra.NroFactura = Convert.ToInt32(txtNroFactura.Text);

                compra.Proveedor = (Proveedor)cmbProveedor.SelectedItem;
                compra.MedioPago = (MedioPago)cmbMedioPago.SelectedItem;
                compra.FechaCompra = dtpFechaCompra.Value.Date;
                compra.MontoTotal = Convert.ToDouble(lblTotalMonto.Text);
                Compra.AgregarCompra(compra);
                MessageBox.Show("La compra ha sido guardado con éxito");
                LimpiarFormulario();
                dgvCompra.DataSource = null;
                dtpFechaCompra.Value = System.DateTime.Now;
                cboArticulo.SelectedItem = null;
                cmbProveedor.SelectedItem = null;

                compra = new Compra();
                gbxCabecera.Enabled = true;
                gbxDetalle.Enabled = false;
            }
        }

        private bool ValidarMonto()
        {
            if (String.IsNullOrWhiteSpace(lblTotalMonto.Text))
            {
                MessageBox.Show("El  total no puede estar vacío, favor calcular", "Error");
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
                txtCosto.Text = Convert.ToString(articulo.Costo);
            }
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Proveedor proveedor = (Proveedor)cmbProveedor.SelectedItem;
            if (proveedor != null)
            {
                txtDireccion.Text = proveedor.Direccion;
            }
        }
    }
}

