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
    public partial class frmArticulo : Form
    {
        public frmArticulo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id = 0;
            Articulo articulo = new Articulo();
            articulo.Descripcion = txtDescripcion.Text;
            int.TryParse(txtId.Text, out id);
            articulo.Marca = txtMarca.Text;
            articulo.Precio_Unit = (double)dmbPrecioUnit.UpDownAlign;
            articulo.Costo = (double)dmbCosto.UpDownAlign;
            articulo.Fecha_Venc = dateVencimiento.Value;


            Articulo.AgregarArticulo(articulo);
            LimpiarFormulario();
            ActualizarListaProveedores();

        }

        private void ActualizarListaProveedores()
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
            dmbCosto.Text = "0";
            dmbPrecioUnit.Text = "0";
            cmbProveedor.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int index = lstArticulos.SelectedIndex;
            Articulo a = ObtenerArticuloFormulario();
            Articulo.ModificarArticulo(a, index);


            LimpiarFormulario();
            ActualizarListaProveedores();
        }

        private Articulo ObtenerArticuloFormulario()
        {          
            Articulo articulo = new Articulo();
            articulo.Id = Convert.ToInt16(txtId.Text);
            articulo.Descripcion = txtDescripcion.Text;
            articulo.Marca = txtMarca.Text;
            articulo.Precio_Unit = Convert.ToDouble(dmbPrecioUnit.Text);
            articulo.Costo = Convert.ToDouble(dmbCosto.Text);
            articulo.Fecha_Venc = dateVencimiento.Value;
            //articulo.Proveedor = (Proveedor)cmbProveedor.Text;
            return articulo;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstArticulos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila");
            }
            else
            {
                Articulo a = (Articulo)lstArticulos.SelectedItem;
                Articulo.EliminarArticulo(a);
                ActualizarListaProveedores();
                LimpiarFormulario();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void lstArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Articulo a = (Articulo)lstArticulos.SelectedItem;

            if (a != null)
            {
                txtId.Text = Convert.ToString(a.Id);
                txtDescripcion.Text = a.Descripcion;
                txtMarca.Text = a.Marca;
                dmbCosto.Text = Convert.ToString(a.Costo);
                dmbPrecioUnit.Text = Convert.ToString(a.Precio_Unit);
                dateVencimiento.Value = a.Fecha_Venc;
                cmbProveedor.Text = Convert.ToString(a.Proveedor);
            }
        }
    }
}
