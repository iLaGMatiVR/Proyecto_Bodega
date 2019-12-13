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
            if (ValidarDatos())
            {
                modo = "I";
                Articulo articulos = (Articulo)lstArticulos.SelectedItem;


                Articulo articulo = ObtenerArticuloFormulario();
                Articulo.AgregarArticulo(articulo);

                ActualizarListaArticulos();
                LimpiarFormulario();
                txtDescripcion.Focus();
            }
            
        }

        private bool ValidarDatos()
        {
            if (String.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La Descripcion no puede estar vacío", "Error");
                txtDescripcion.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("La Marca no puede estar vacío", "Error");
                txtMarca.Focus();
                return false;
            }
            if (nudCosto.Value <= 0 || nudCosto.Value > 1000000)
            {
                MessageBox.Show("Por favor ingrese un costo mayor a cero", "Error");
                nudCosto.Focus();
                return false;
            }
            if (nudPrecioUnit.Value <= 0 || nudPrecioUnit.Value > 1000000)
            {
                MessageBox.Show("Por favor ingrese precio unitario mayor a cero", "Error");
                nudPrecioUnit.Focus();
                return false;
            }
            
           
            var fechaIncorrecta = new DateTime(2100, 1, 1);

            if (dtpVencimiento.Value < DateTime.Now || dtpVencimiento.Value > DateTime.Parse("01/01/2100") || dtpVencimiento.Value > fechaIncorrecta)
            {
                MessageBox.Show("Por favor ingrese una fecha de vencimiento correcta", "Error");
                dtpVencimiento.Focus();
                return false;
            }
            var pro = (Proveedor)cmbProveedor.SelectedItem;
            if (pro == null)
            {
                MessageBox.Show("Por favor seleccione un Proveedor", "Error");
                cmbProveedor.Focus();
                return false;
            }


            return true;
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
            dtpVencimiento.Value = DateTime.Now;
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
            articulo.Fecha_Venc = dtpVencimiento.Value;

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
                dtpVencimiento.Value = articulo.Fecha_Venc;
                nudCosto.Value = Convert.ToInt32(articulo.Costo);
                nudPrecioUnit.Value = Convert.ToInt32(articulo.Precio_Unit);

            }
        }
    }
}
