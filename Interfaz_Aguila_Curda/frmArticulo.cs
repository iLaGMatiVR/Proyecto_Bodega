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
        string modo;
        public frmArticulo()
        {
            InitializeComponent();
        }

        //Boton Agregar articulo
        private void btnAgregar_Click(object sender, EventArgs e)
        {            

            if (modo == "AGREGAR")
            {
                Articulo articulo = ObtenerDatosFormulario();
                Articulo.AgregarArticulo(articulo);
            }
            else if (modo == "MODIFICAR")
            {

                if (this.lstArticulo.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Favor seleccione una fila");
                }

                else
                {
                    int indice = lstArticulo.SelectedIndex;
                    Articulo.ListaArticulos[indice] = ObtenerDatosFormulario();
                }


            }

            LimpiarFormulario();
            ActualizarListaArticulos();

        }

        private void LimpiarFormulario()
        {
            txtDescripcion.Text = "";
            txtId.Text = "0";
            txtMarca.Text = "";
            cmbProveedor.Text = "";
            nudPrecio_unit.Value = 0;
            nudCosto.Value = 0;
            dateVencimiento.Value = DateTime.Now;
        }

        private void ActualizarListaArticulos()
        {
            lstArticulo.DataSource = null;
            lstArticulo.DataSource = Articulo.ObtenerArticulos();
        }

        private Articulo ObtenerDatosFormulario()
        {
            int id = 0;
            Articulo articulo = new Articulo();
            articulo.Descripcion = txtDescripcion.Text;
            int.TryParse(txtId.Text, out id);
            articulo.Marca = txtMarca.Text;
            articulo.Precio_Unit = (double)nudPrecio_unit.Value;
            articulo.Costo = (double)nudCosto.Value;
            articulo.Fecha_Venc = dateVencimiento.Value.Date;
            articulo.Proveedor = (Proveedor)cmbProveedor.SelectedItem;

            return articulo;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modo = "MODIFICAR";
            txtDescripcion.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstArticulo.SelectedItems.Count > 0)
            {
                Articulo articulo = (Articulo)lstArticulo.SelectedItem;
                Articulo.ListaArticulos.Remove(articulo);
                ActualizarListaArticulos();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Favor seleccionar de la lista para eliminar");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            ActualizarListaArticulos();
            //cmbProveedor.DataSource = Proveedor.ObtenerProveedores();            
            cmbProveedor.SelectedItem = null;
            txtDescripcion.Focus();
        }

        private void lstArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstArticulo_Click(object sender, EventArgs e)
        {
            Articulo a = (Articulo)lstArticulo.SelectedItem;

            if (a != null)
            {
                int id = 0;
                txtDescripcion.Text = a.Descripcion;
                int.TryParse(txtId.Text, out id);
                txtMarca.Text = a.Marca;
                nudPrecio_unit.Value = (decimal)a.Precio_Unit;
                nudCosto.Value = (decimal)a.Costo;
                dateVencimiento.Value = a.Fecha_Venc;
                cmbProveedor.SelectedItem = a.Proveedor;
            }
        }

        private void cc(object sender, EventArgs e)
        {

        }
    }
}

