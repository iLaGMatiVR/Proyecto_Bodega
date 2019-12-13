using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaComun.Cache;

namespace Interfaz_Aguila_Curda
{
    public partial class frmMenuPro : Form
    {
        public frmMenuPro()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessagge(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 50;
            }
            else
                MenuVertical.Width = 250;
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRestaurar.Visible = false;
            icoMaximizar.Visible = true;
        }

       

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessagge(this.Handle, 0x112,0xf012,0);
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmArticulo());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmFacturas());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmCliente());
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmProveedor());
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmCompra());
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmDevolucion());
        }

        private void icoMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestaurar.Visible = true;
            icoMaximizar.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            this.Close();
        }

        private void LoadUserData()
        {
            lblNombre.Text = UserLoginCache.Nombre+","+UserLoginCache.Apellido;
            lblCargo.Text = UserLoginCache.Cargo;
            lblEmail.Text = UserLoginCache.Email;
        }

        private void frmMenuPro_Load(object sender, EventArgs e)
        {
            LoadUserData();
            //Administrar Permisos
           if(UserLoginCache.Cargo == Cargos.Cajero)
            {
                btnCompra.Enabled = false;
                btnReporte.Enabled = false;
                btnProveedor.Enabled = false;
            }
        }

        private void btnReporte_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmReporteArticulo());
        }
    }
}
