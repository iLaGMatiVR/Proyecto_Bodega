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

    public partial class frmDevolucion : Form
    {
        Devolucion devolucion;
        Articulo articulo;
        public frmDevolucion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Devolucion dv = new Devolucion();
            dv.Motivo_Devolucion = txtMotivoDevolucion.Text;
            dv.Descripcion = (Articulo)cmbDescripcion.SelectedItem;
            Devolucion.AgregarDevolucion(dv);
            ActualizarDataGrid();

            Limpiar();
        }

        private void Limpiar()
        {
            txtMotivoDevolucion.Text = "";
            cmbDescripcion.SelectedItem = null;
        }

        private void ActualizarDataGrid()
        {
            dtgDetalleDevolucion.DataSource = null;
            dtgDetalleDevolucion.DataSource = Devolucion.ObtenerDevoluciones();
        }

        private void frmDevolucion_Load(object sender, EventArgs e)
        {
            dtgDetalleDevolucion.AutoGenerateColumns = true;
            cmbDescripcion.DataSource = Articulo.ObtenerArticulos();
            cmbDescripcion.SelectedItem = null;
            devolucion = new Devolucion();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Devolucion dv = (Devolucion)dtgDetalleDevolucion.CurrentRow.DataBoundItem;
            Devolucion.EliminarDevolucion(dv);
            ActualizarDataGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            devolucion.articulo = (Articulo)cmbDescripcion.SelectedItem;

            Devolucion.AgregarDevolucion(devolucion);
            MessageBox.Show("El pedido ha sido guardado con éxito");
            Limpiar();
            dtgDetalleDevolucion.DataSource = null;
            cmbDescripcion.SelectedItem = null;
            devolucion = new Devolucion();
        }

        private void lblDescripcionDelProducto_Click(object sender, EventArgs e)
        {

        }

        private void cmbDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtmFechaDevolucion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblFechaDevolucion_Click(object sender, EventArgs e)
        {

        }

        private void lblMotivoDevolucion_Click(object sender, EventArgs e)
        {

        }
    }
}
