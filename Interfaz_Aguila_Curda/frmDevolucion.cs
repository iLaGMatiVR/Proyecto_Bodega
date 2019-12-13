using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Bodega;


namespace Interfaz_Aguila_Curda
{

    public partial class frmDevolucion : Form
    {
        string modo;

        public frmDevolucion()
        {
            InitializeComponent();
        }





        private void ActualizarListaDevolucion()
        {
            lstDevolucion.DataSource = null;
            lstDevolucion.DataSource = Devolucion.ObtenerDevoluciones();
        }

        private void LimpiarFormulario()

        {
            txtIDDevolucion.Text = "";
            txtMotivoDevolucion.Text = "";
            dtpFechaDevolucion.Value = System.DateTime.Now;
            cmbDescripcion.SelectedItem = null;


        }



        private Devolucion ObtenerDevolucionFormulario()
        {
            Devolucion devolucion = new Devolucion();
            if (!string.IsNullOrEmpty(txtIDDevolucion.Text))
            {
                devolucion.Id = Convert.ToInt32(txtIDDevolucion.Text);
            }

            devolucion.Motivo_Devolucion = txtMotivoDevolucion.Text;
            devolucion.FechaDevol = dtpFechaDevolucion.Value.Date;

            devolucion.Articulo = (Articulo)cmbDescripcion.SelectedItem;

            return devolucion;
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                modo = "AGREGAR";
                Devolucion devolucion = new Devolucion();
                devolucion.Motivo_Devolucion = txtMotivoDevolucion.Text;
                devolucion.FechaDevol = dtpFechaDevolucion.Value.Date;
                devolucion.Articulo = (Articulo)cmbDescripcion.SelectedItem;

                Devolucion.AgregarDevolucion(devolucion);
                LimpiarFormulario();
            }

            ActualizarListaDevolucion();


        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtMotivoDevolucion.Text))
            {
                MessageBox.Show("El motivo no puede estar vacío", "Error");
                txtMotivoDevolucion.Focus();
                return false;
            }
            if (txtMotivoDevolucion.Text.Length < 1 || txtMotivoDevolucion.Text.Length > 55)
            {
                ;
                MessageBox.Show("La longitud de caracteres es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMotivoDevolucion.Focus();
                return false;
            }



            if (dtpFechaDevolucion.Value >= DateTime.Now)
            {
                MessageBox.Show("Por favor ingrese una fecha de devolucion correcta", "Error");
                dtpFechaDevolucion.Focus();
                return false;
            }

            if (cmbDescripcion.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione una Descripcion del Producto", "Error");
                cmbDescripcion.Focus();
                return false;
            }
            return true;
        }
        private void frmDevolucion_Load(object sender, EventArgs e)
        {
            ActualizarListaDevolucion();
            cmbDescripcion.DataSource = Articulo.ObtenerArticulos();
            cmbDescripcion.SelectedItem = null;
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                modo = "EDITAR";
                Devolucion devolucion = (Devolucion)lstDevolucion.SelectedItem;
                if (lstDevolucion.SelectedItems.Count > 0)
                {

                    int index = lstDevolucion.SelectedIndex;
                    Devolucion d = ObtenerDevolucionFormulario();
                    Devolucion.EditarDevolucion(index, d);
                    ActualizarListaDevolucion();

                }
                else
                {
                    MessageBox.Show("Favor seleccionar de la fila para modificar");
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Devolucion devolucion = (Devolucion)lstDevolucion.SelectedItem;
            if (this.lstDevolucion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccionar una fila de la lista");
            }
            else
            {

                Devolucion.EliminarDevolucion(devolucion);
                ActualizarListaDevolucion();
                LimpiarFormulario();
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void lstDevolucion_Click_1(object sender, EventArgs e)
        {
            Devolucion devolucion = (Devolucion)lstDevolucion.SelectedItem;
            if (devolucion != null)
            {
                txtIDDevolucion.Text = Convert.ToString(devolucion.Id);
                txtMotivoDevolucion.Text = devolucion.Motivo_Devolucion;
                dtpFechaDevolucion.Value = devolucion.FechaDevol;
                cmbDescripcion.SelectedItem = devolucion.Articulo;

            }
        }
    }

}
