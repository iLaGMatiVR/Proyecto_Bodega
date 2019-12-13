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
using CapaComun.Cache;

namespace Interfaz_Aguila_Curda
{
    public partial class frmArticulo : Form
    {
        public string modo;
        public frmArticulo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = "I";
            Articulo articulos = (Articulo)lstArticulos.SelectedItem;


            Articulo articulo = ObtenerArticuloFormulario();
            Articulo.AgregarArticulo(articulo);

            /*if (articulos == null)
            {

                Articulo articulo = ObtenerArticuloFormulario();
                Articulo.AgregarArticulo(articulo);
            }
            else if (articulos != null)
            {
                modo = "E";
                int index = lstArticulos.SelectedIndex;
                Articulo articulo = ObtenerArticuloFormulario();
                Articulo.ModificarArticulo(index, articulo);
            }
            */


            ActualizarListaArticulos();
            LimpiarFormulario();
            txtDescripcion.Focus();
        }



        private void ActualizarListaArticulos()
        {
            lstArticulos.DataSource = null;
            lstArticulos.DataSource = Articulo.ObtenerArticulos();
        }

        private void LimpiarFormulario()
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
            txtMarca.Text = "";
            dateVencimiento.Value = DateTime.Now;
            nudCosto.Text = "0";
            nudPrecioUnit.Text = "0";
            cmbProveedor.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Articulo articulo = (Articulo)lstArticulos.SelectedItem;
            if (articulo != null)
            {
                modo = "E";
                int index = lstArticulos.SelectedIndex;
                Articulo articulos = ObtenerArticuloFormulario();
                Articulo.ModificarArticulo(index, articulos);
            }
            else
            {
                MessageBox.Show("Por favor, Seleccione un Item");
            }
            LimpiarFormulario();
            ActualizarListaArticulos();
        }

        private Articulo ObtenerArticuloFormulario()
        {
            Articulo articulo = new Articulo();


            if (!string.IsNullOrEmpty(txtId.Text))
            {
                articulo.Id = Convert.ToInt32(txtId.Text);
            }
            articulo.Descripcion = txtDescripcion.Text;
            articulo.Marca = txtMarca.Text;
            articulo.Precio_Unit = Convert.ToDouble(nudPrecioUnit.Text);
            articulo.Costo = Convert.ToDouble(nudCosto.Text);
            articulo.Fecha_Venc = dateVencimiento.Value;

            articulo.Proveedor = (Proveedor)cmbProveedor.SelectedItem;

            return articulo;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo articulo = (Articulo)lstArticulos.SelectedItem;
            if (articulo != null)
            {
                Articulo.EliminarArticulo(articulo);
                ActualizarListaArticulos();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila de la lista");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            ActualizarListaArticulos();
            cmbProveedor.DataSource = Proveedor.ObtenerProveedores();
            //cmbProveedor.SelectedIndex = 1;
            cmbProveedor.SelectedItem = null;
            //Administrar Permisos
            if (UserLoginCache.Cargo == Cargos.Cajero)
            {
                btnAgregar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;


            }
        }
       

        private void lstArticulos_Click_1(object sender, EventArgs e)
        {
            Articulo articulo = (Articulo)lstArticulos.SelectedItem;
            if (articulo != null)
            {
                txtId.Text = Convert.ToString(articulo.Id);
                txtDescripcion.Text = articulo.Descripcion;
                txtMarca.Text = articulo.Marca;
                cmbProveedor.SelectedItem = articulo.Proveedor;
                dateVencimiento.Value = articulo.Fecha_Venc;
                nudCosto.Value = Convert.ToInt32(articulo.Costo);
                nudPrecioUnit.Value = Convert.ToInt32(articulo.Precio_Unit);


            }
        }
    }
}
