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
        public string modo;
        public frmArticulo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (modo == "I")
            {
                Articulo articulo = ObtenerArticuloFormulario();
                Articulo.AgregarArticulo(articulo);
            }
            else if (modo == "E")
            {
                int index = lstArticulos.SelectedIndex;
                Articulo articulo = ObtenerArticuloFormulario();
                Articulo.ModificarArticulo(index, articulo);
            }

            ActualizarListaArticulos();
            LimpiarFormulario();            
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

        private void lstArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            Articulo a = (Articulo)lstArticulos.SelectedItem;
            txtDescripcion.Text = a.Descripcion;
            txtMarca.Text = a.Marca;
            nudCosto.Text = Convert.ToString(a.Costo);
            nudPrecioUnit.Text = Convert.ToString(a.Precio_Unit);
            dateVencimiento.Value = a.Fecha_Venc;
            cmbProveedor.SelectedItem = a.Proveedor.NroDocumento;
        }
    }//insertando comentarios al azar
}
